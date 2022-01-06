using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Cibercafe_ElVicio
{
    public partial class FrmMenu : Form
    {
        /// <summary>
        /// Coloca el nombre del usuario en la barra superior del form y tambien la fecha de hoy.
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
            lblUsuario.Text = "Tomás Agustín Friz";
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        
        /// <summary>
        /// Sirve para cerrar la aplicacion.
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
                "+ El boton 'Cerrar' te preguntara si deseas cerrar. 'SI' cerrara la aplicacion, incluyendo las ventanas abiertas. 'NO' regresaras al menu principal.\n" +
                "+ El boton 'Asignar Equipo' te permitira asignar un equipo al cliente.\n" +
                "+ El boton 'Estadisticas Historicas' te permitira ver el historial segun el criterio que elijas\n" +
                "+ Podras ver la lista de espera de los clientes en el cuadro blanco del centro\n" +
                "+ En el lado superior podra ver el nombre del negocio y el usuario conectado mas la fecha del dia de hoy\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Sirve para asignar los equipos de los clientes en orden de llegada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAsigEquipo_Click(object sender, EventArgs e)
        {
            if (Usuario.Clientes.Count > 0)
            {
                Cliente c = Usuario.Clientes.Peek();
                if (c.Servicio is ClienteComputadora)
                {
                    FrmComputadoras frmComputadoras = new();
                    frmComputadoras.ShowDialog();
                }
                else
                {
                    FrmTelefonos frmTelefonos = new();
                    frmTelefonos.ShowDialog();
                }
            }
        }
        /// <summary>
        /// Sirve para ver las estadisticas historicas relacionadas con los clientes y el uso de las maquinas y cabinas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new();
            frmHistorial.ShowDialog();
        }
        /// <summary>
        /// Sirve para ver las especificaciones de todas las computadoras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEspecificacion_Click(object sender, EventArgs e)
        {
            FrmEspecificaciones frmEspecificaciones = new();
            frmEspecificaciones.ShowDialog();
        }
        /// <summary>
        /// Se encarga de hardcodear los datos de los clientes y saludar al usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡BIENVENIDO USUARIO!");
            List<Cliente> lista = new()
            {
                new Cliente(41918909, "Tomás", "Sánchez", 22, new ClienteComputadora()),                
                new Cliente(31456980, "Gustavo", "Doria", 53, new ClienteComputadora()),       
                new Cliente(27643934, "Brisa", "Quinteros", 48, new ClienteComputadora()),
                new Cliente(19934027, "Pedro", "Macri", 61, new ClienteTelefono()),
                new Cliente(34067132, "Mauricio", "Prieto", 35, new ClienteTelefono()),
                new Cliente(36897132, "Belén", "Trinidad", 16, new ClienteTelefono())
            };
            foreach (Cliente cliente in lista)
            {
                Usuario.AgregarCliente(cliente);
            }
            //Actualizo los clientes.
            listCliente.Items.Clear();
            foreach (Cliente cliente in Usuario.Clientes)
            {
                listCliente.Items.Add(cliente.ToString());
            }
            List<Equipo> listaComputadora = new()
            {
                new Computadora("C01", new List<Software>(){Software.ares,Software.messenger,Software.icq}, new List<Periferico>() {Periferico.auriculares,Periferico.micrófono}, new List<Juego>() {Juego.CounterStrike,Juego.MuOnline,Juego.DiabloII,Juego.WarcraftIII}, new Dictionary<Hardware, string> {{Hardware.RAM, "6GB"}, {Hardware.procesador, "Intel Pentium 2"}, {Hardware.placaVideo, "9600GT"} }),
                new Computadora("C02", new List<Software>(){Software.icq,Software.office,Software.ares}, new List<Periferico>() {Periferico.cámara,Periferico.auriculares}, new List<Juego>() {Juego.AgeOfEmpiresII,Juego.CounterStrike,Juego.MuOnline,Juego.LineageII}, new Dictionary<Hardware, string> {{Hardware.RAM, "3GB"}, {Hardware.procesador, "Intel Pentium 4"}, {Hardware.placaVideo, "Geforce 4"}}),
                new Computadora("C03", new List<Software>(){Software.messenger,Software.icq,Software.office}, new List<Periferico>() {Periferico.micrófono,Periferico.auriculares}, new List<Juego>() {Juego.CounterStrike,Juego.MuOnline,Juego.LineageII,Juego.AgeOfEmpiresII}, new Dictionary<Hardware, string> {{Hardware.RAM, "1GB"}, {Hardware.procesador, "Intel Pentium 4"}, {Hardware.placaVideo, "486 DLC" } }),
                new Computadora("C04", new List<Software>(){Software.office,Software.messenger,Software.ares}, new List<Periferico>() {Periferico.auriculares,Periferico.cámara}, new List<Juego>() {Juego.DiabloII,Juego.CounterStrike,Juego.WarcraftIII,Juego.MuOnline}, new Dictionary<Hardware, string> {{Hardware.RAM, "7GB"}, {Hardware.procesador, "Intel Pentium 1"}, {Hardware.placaVideo, "Geforce 4" } }),
                new Computadora("C05", new List<Software>(){Software.ares,Software.icq,Software.messenger}, new List<Periferico>() {Periferico.cámara,Periferico.micrófono}, new List<Juego>() {Juego.LineageII,Juego.CounterStrike,Juego.AgeOfEmpiresII,Juego.MuOnline}, new Dictionary<Hardware, string> {{Hardware.RAM, "14GB"}, {Hardware.procesador, "Intel Pentium 3"}, {Hardware.placaVideo, "9600GT"}}),
                new Computadora("C06", new List<Software>(){Software.icq,Software.messenger,Software.office}, new List<Periferico>() {Periferico.micrófono,Periferico.cámara}, new List<Juego>() {Juego.WarcraftIII,Juego.DiabloII,Juego.CounterStrike,Juego.LineageII}, new Dictionary<Hardware, string> {{Hardware.RAM, "8GB"}, {Hardware.procesador, "Intel 4004"}, {Hardware.placaVideo, "486 DLC"}}),
                new Computadora("C07", new List<Software>(){Software.messenger,Software.office,Software.icq}, new List<Periferico>() {Periferico.auriculares,Periferico.micrófono}, new List<Juego>() {Juego.MuOnline,Juego.AgeOfEmpiresII,Juego.LineageII,Juego.WarcraftIII}, new Dictionary<Hardware, string> {{Hardware.RAM, "15GB"}, {Hardware.procesador, "Intel Pentium 3"}, {Hardware.placaVideo, "9600GT" } }),
                new Computadora("C08", new List<Software>(){Software.office,Software.ares,Software.messenger}, new List<Periferico>() {Periferico.cámara,Periferico.micrófono}, new List<Juego>() {Juego.CounterStrike,Juego.WarcraftIII,Juego.MuOnline,Juego.LineageII}, new Dictionary<Hardware, string> {{Hardware.RAM, "2GB"}, {Hardware.procesador, "Intel 4004"}, {Hardware.placaVideo, "Geforce 4" } }),
                new Computadora("C09", new List<Software>(){Software.ares,Software.office,Software.icq}, new List<Periferico>() {Periferico.micrófono,Periferico.cámara}, new List<Juego>() {Juego.DiabloII,Juego.MuOnline,Juego.AgeOfEmpiresII,Juego.WarcraftIII}, new Dictionary<Hardware, string> {{Hardware.RAM, "9GB"}, {Hardware.procesador, "Intel Pentium 1"}, {Hardware.placaVideo, "486 DLC"}}),
                new Computadora("C10", new List<Software>(){Software.icq,Software.ares,Software.office}, new List<Periferico>() {Periferico.auriculares,Periferico.micrófono}, new List<Juego>() {Juego.WarcraftIII,Juego.AgeOfEmpiresII,Juego.LineageII,Juego.CounterStrike}, new Dictionary<Hardware, string> {{Hardware.RAM, "7GB"}, {Hardware.procesador, "Intel Pentium 1"}, {Hardware.placaVideo, "9600GT"}}),
            };
            foreach (Equipo compu in listaComputadora)
            {
                Usuario.AgregarEquipo(compu);
            }
            List<Equipo> listaTelefonos = new()
            {
                new Telefono("T01", TipoTecla.Disco, "Telefonica"),
                new Telefono("T02", TipoTecla.Teclado, "Panasonic"),
                new Telefono("T03", TipoTecla.Disco, "Elgin"),
                new Telefono("T04", TipoTecla.Teclado, "Siemens"),
                new Telefono("T05", TipoTecla.Disco, "Panasonic")
            };
            foreach (Equipo telefono in listaTelefonos)
            {
                Usuario.AgregarEquipo(telefono);
            }
        }

        /// <summary>
        /// Se encarga de desconectar la computadora y genera una factura.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblComputadoras_Click(object sender, EventArgs e) 
        {
            for(int i = 0; i < Usuario.Lista.Count; i++)
            {
                if (((Label)sender).Text == Usuario.Lista[i].Id)
                {
                    Equipo computadora = Usuario.Lista[i];
                    if (computadora.Estado == Estado.En_Uso)
                    {
                        Usuario.FinalizarServicio(computadora);
                        FrmFactura frmFactura = new(computadora.Lista.Last());
                        frmFactura.ShowDialog();
                    }
                }
            }
        }
        /// <summary>
        /// Se encarga de colgar el telefono y genera una factura.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblTelefonos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Usuario.Lista.Count; i++)
            {
                if (((Label)sender).Text == Usuario.Lista[i].Id)
                {
                    Equipo telefono = Usuario.Lista[i];
                    if (telefono.Estado == Estado.En_Uso)
                    {
                        Usuario.FinalizarServicio(telefono);
                        FrmFactura frmFactura = new(telefono.Lista.Last());
                        frmFactura.ShowDialog();
                    }
                }
            }
        }

        /// <summary>
        /// Sirve para confirmar el cerrado del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCibercafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Seguro de querer salir?", "Saliendo.....", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = msj == DialogResult.No;
        }
        /// <summary>
        /// Actualiza los clientes (Una vez que se le asignaron un equipo al cliente desaparecera de la lista de espera).
        /// Actualiza los labels de computadoras y telefonos (cambia de color si esta libre o en uso).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Activated(object sender, EventArgs e)
        {
            //Actualiza los clientes.
            listCliente.Items.Clear();
            foreach (Cliente cliente in Usuario.Clientes)
            {
                listCliente.Items.Add(cliente.ToString());
            }
            //Actualiza las computadoras.
            for (int i = 0; i < gpbComputadoras.Controls.Count; i++)
            {
                if (gpbComputadoras.Controls[i] is Label)
                {
                    foreach (Equipo equipo in Usuario.Lista)
                    {
                        if (gpbComputadoras.Controls[i].Text == equipo.Id)
                        {
                            if (equipo.Estado == Estado.Disponible)
                            {
                                gpbComputadoras.Controls[i].BackColor = Color.Lime;
                            }
                            else
                            {
                                gpbComputadoras.Controls[i].BackColor = Color.Crimson;
                            }
                        }
                    }
                }
            }
            //Actualiza los Telefonos.
            for (int i = 0; i < gpbTelefonos.Controls.Count; i++)
            {
                if (gpbTelefonos.Controls[i] is Label)
                {
                    foreach (Equipo equipo in Usuario.Lista)
                    {
                        if (gpbTelefonos.Controls[i].Text == equipo.Id)
                        {
                            if (equipo.Estado == Estado.Disponible)
                            {
                                gpbTelefonos.Controls[i].BackColor = Color.Lime;
                            }
                            else
                            {
                                gpbTelefonos.Controls[i].BackColor = Color.Crimson;
                            }
                        }
                    }
                }
            }
        }
    }
}
