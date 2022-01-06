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
    public partial class FrmFactura : Form
    {
        private readonly Servicio factura;

        /// <summary>
        /// Constructor de Frmfactura
        /// </summary>
        public FrmFactura()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor de Frmfactura para los servicios.
        /// </summary>
        /// <param name="s"></param>
        public FrmFactura(Servicio s) : this()
        {
            factura = s;
        }

        /// <summary>
        /// Sirve para pagar el uso de los equipos mas si pidio un aperitivo (incluye IVA integrado).
        /// Cierra la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPagar_Click(object sender, EventArgs e)
        {
            txtDuracion.Text = $"{factura.Duracion} minutos";
            txtCosto.Text = $"${factura.Costo + PreciosAperitivos()}";
            txtIVA.Text = $"${factura.AgregarIVA() }";
            btnCerrar.Enabled = true;
            gpbAperitivos.Enabled = false;
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
               "+ El boton 'Pagar' sirve para pagar el servicio y si compraste un aperitivo.\n" +
               "+ El boton 'Cerrar' cierra la ventana actual.\n" +
               "+ En el lado superior estara un cuadro gris para seleccionar que pidio de aperitivo el cliente (opcional).\n" +
               "+ En el lado inferior estara los detalles de la duracion del equipo que uso el cliente, el costo de uso del equipo mas si pidio un aperitivo y el iva de los costos del cliente.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Sirve para imprimir la duracion, el costo general, y el costo con IVA del servicio que solicito el cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFactura_Load(object sender, EventArgs e)
        {
            if (factura is ClienteTelefono)
            {
                txtTipo.Text = $"{((ClienteTelefono)factura).Tipo}";
            }
            else
            {
                txtTipo.Text = $"{((ClienteComputadora)factura).Tipo}";
            }
            txtDuracion.Text = $"{factura.Duracion} minutos";
            txtCosto.Text = $"${factura.Costo}";
            txtIVA.Text = $"${factura.AgregarIVA()}";
            btnCerrar.Enabled = false;
        }

        /// <summary>
        /// Funcion para establecer los precios de los aperitivos en los checkbox.
        /// </summary>
        /// <returns></returns>
        private float PreciosAperitivos()
        {
            int indice = 0;
            if (cbCafe.Checked)
            {
                indice += 10;
            }
            if (cbSoda.Checked)
            {
                indice += 5;
            }
            if (cbTostado.Checked)
            {
                indice += 25;
            }
            if (cbDona.Checked)
            {
                indice += 20;
            }
            return indice;
        }
    }
}
