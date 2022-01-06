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
    public partial class FrmComputadoras : Form
    {
        protected Cliente cliente;
        protected ClienteComputadora computadora;

        /// <summary>
        /// Constructor de FrmComputadoras.
        /// </summary>
        public FrmComputadoras()
        {
            InitializeComponent();
            cliente = Usuario.Clientes.Peek();
            computadora = (ClienteComputadora)cliente.Servicio;
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
                "+ El boton 'Conectar' le dara al cliente la computadora asignada.\n" +
                "+ En el cuadro blanco del lado izquierdo se mostraran las especificaciones del cliente.\n" +
                "+ En el cuadro gris del lado derecho inferior se mostraran los datos del cliente.\n" +
                "+ En el lado superior derecho se podra elegir si el cliente lo quiere la maquina sin temporizador o con temporizador.\n" +
                "+ Aparecera un temporizador para marcar los minutos que decida usar el cliente cuando este marcada el check de 'Tiempo Limitado'.\n" +
                "+ En el cuadro gris del lado izquierdo en el centro estaran las computadoras disponibles con las especificaciones del cliente.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Sirve para conectar al cliente a una computadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if (rbtLimitado.Checked && nudTiempoLimite.Value % 30 != 0)
            {
                MessageBox.Show("La duración limite debe limitarse en bloques de media hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtIlimitado.Checked)
                {
                    computadora.Tipo = TipoCompu.Libre;
                }
                else
                {
                    computadora.Duracion = (int)nudTiempoLimite.Value;
                    computadora.Tipo = TipoCompu.Limitado;
                }

                foreach (Equipo equipo in Usuario.Lista)
                {
                    if (equipo.Id == (string)cmbComputadoras.SelectedItem)
                    {
                        if (Usuario.AgregarServicio(equipo, computadora))
                        {
                            Close();
                            Usuario.Clientes.Dequeue();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Se encarga de cargar los datos del cliente, las especificaciones del mismo y las computadoras que coinciden con las especificaciones del cliente.
        /// Si no hay computadoras disponibles se bloquara el boton de conectar y se oscurecera a un color DarkGray (gris oscuro).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmComputadoras_Load(object sender, EventArgs e)
        {
            lblDatos.Text = cliente.ToString();
            rctEspecificaciones.Text = computadora.MostrarEspecificaciones();
            List<string> computadorasDisponibles = new();
            foreach (Equipo equipo in Usuario.Lista)
            {
                if (equipo is Computadora compu)
                {
                    if (equipo.Estado == Estado.Disponible)
                    {
                        if (Usuario.RevisarRequisitos((ClienteComputadora)(cliente.Servicio),compu))
                        {
                            computadorasDisponibles.Add(equipo.Id);
                        }
                    }
                }
            }
            if (computadorasDisponibles.Count > 0)
            {
                cmbComputadoras.DataSource = computadorasDisponibles;
            }
            else
            {
                btnConectar.Enabled = false;
                btnConectar.BackColor = Color.DarkGray;
                cmbComputadoras.Items.Add("No hay computadoras disponibles.");
            }
        }

        /// <summary>
        /// Se encarga de poner invisible el numTiempoLimite cuando el check esta marcado en tiempo ilimitado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbtIlimitado_CheckedChanged(object sender, EventArgs e)
        {
            nudTiempoLimite.Visible = false;
        }
        /// <summary>
        /// Se encarga de poner visible el numTiempoLimite cuando el check esta marcado en tiempo limitado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbtLimitado_CheckedChanged(object sender, EventArgs e)
        {
            nudTiempoLimite.Visible = true;
        }
    }
}
