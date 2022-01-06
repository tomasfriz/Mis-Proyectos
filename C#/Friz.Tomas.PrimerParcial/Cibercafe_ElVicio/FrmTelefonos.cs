using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Cibercafe_ElVicio
{
    public partial class FrmTelefonos : Form
    {
        private readonly Cliente cliente;
        private readonly ClienteTelefono telefono;

        /// <summary>
        /// Constructor de FrmTelefonos.
        /// </summary>
        public FrmTelefonos()
        {
            InitializeComponent();

            cliente = Usuario.Clientes.Peek();
            telefono = (ClienteTelefono)cliente.Servicio; 
        }

        /// <summary>
        /// Sirve para cerrar la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Sirve para orientar al usuario a saber que hace cada boton de la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IbtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+ El boton 'Ayuda' te ayudara a saber el funcionamiento de los botones.\n" +
                "+ El boton 'Cerrar' cierra la ventana actual.\n" +
                "+ El boton 'Llamar' le dara al cliente el telefono asignado.\n" +
                "+ En el cuadro gris del lado inferior se mostraran los datos del cliente.\n" +
                "+ En el lado superior se colocara el codigo, la localidad y el numero telefonico al que quiere llamar el cliente.\n" +
                "+ En el lado central estaran los telefonos disponibles para el cliente.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Sirve para agregar un cliente a un telefono.
        /// Posibilidad de marcar numero telefonico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLlamar_Click(object sender, EventArgs e)
        {
            telefono.Codigo = txtCodigo.Text;
            telefono.Localidad = txtLocalidad.Text;
            telefono.Num = txtNumero.Text;
            ValidadorNuget validar = new();
            if (!(validar.Validate(telefono)).IsValid)
            {
                StringBuilder sb = new();
                foreach (var error in validar.Validate(telefono).Errors)
                {
                    sb.AppendLine($"+ {error.ErrorMessage}");
                }
                MessageBox.Show(sb.ToString(),"Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Equipo equipo in Usuario.EquipoDisponible)
                {
                    if (equipo.Id == (string)cmbTelefonos.SelectedItem)
                    {
                        if (Usuario.AgregarServicio(equipo,telefono))
                        {
                            Usuario.Clientes.Dequeue();
                        }
                    }
                }
                Close();
            }
        }
        /// <summary>
        /// Se encarga de cargar los datos de los telefonos y comparan si estan disponibles.
        /// Si no hay telefonos disponibles se bloquara el boton de llamar y se oscurecera a un color DarkGray (gris oscuro).
        /// </summary>
        private void FrmTelefonos_Load(object sender, EventArgs e)
        {
            lblDatos.Text = cliente.ToString();
            List<string> telefono = new();
            foreach (Equipo equipo in Usuario.EquipoDisponible)
            {
                if (equipo is Telefono)
                {
                    if (equipo.Estado == Estado.Disponible)
                    {
                        telefono.Add(equipo.Id);
                    }
                }
            }
            if (telefono.Count > 0)
            {
                cmbTelefonos.DataSource = telefono;
            }
            else
            {
                btnLlamar.Enabled = false;
                btnLlamar.BackColor = Color.DarkGray;
                cmbTelefonos.Items.Add("No hay telefonos disponibles.");
            }
        }
    }
}
