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
    public partial class FrmHistorial : Form
    {
        /// <summary>
        /// Constructor de FrmHistorial.
        /// </summary>
        public FrmHistorial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sirve para cerrar la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSalir_Click(object sender, EventArgs e)
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
                "+ En el cuadro blanco del lado derecho se mostraran la informacion de los botones.\n" +
                "+ En el primer boton del lado superior ordenara de forma decendente y por minutos de uso las computadoras.\n" +
                "+ En el segundo boton ordenara de forma decendente y por minutos de uso los telefonos.\n" +
                "+ En el tercer boton mostraran las ganancias totales y tambien segun su servicio.\n" +
                "+ En el cuarto boton mostraran las horas totales y tambien la recaudacion por tipo de llamadas.\n" +
                "+ En el quinto boton mostrara el software mas pedido por los clientes.\n" +
                "+ En el sexto boton mostrara el periferico mas pedido por los clientes.\n" +
                "+ En el septimo boton mostrara el juego mas pedido por los clientes.\n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Muestra la lista de computadoras ordenadas por minutos de uso de forma descendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnListCompu_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = OrdenamientoDecendenteTiempo(TipoEquipo.Computadora);
        }
        /// <summary>
        /// Muestra la lista de cabinas ordenadas por minutos de uso de forma descendente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnListCabin_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = OrdenamientoDecendenteTiempo(TipoEquipo.Cabina);
        }
        /// <summary>
        /// Muestra las ganancias totales y clasificadas por servicio (teléfono/c).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGanancias_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = CalcularGanancias();
        }
        /// <summary>
        /// Muestra las horas totales y la recaudación por tipo de llamada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHorasYRecaudacion_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = CalcularHorasYRecaudacion();
        }
        /// <summary>
        /// Muestra el software más pedido por los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSoftware_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = MostrarSoftwareFavoritoClientes();
        }
        /// <summary>
        /// Muestra el periférico más pedido por los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPeriferico_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = MostrarPerifericoFavoritoClientes();
        }
        /// <summary>
        /// Muestra el juego más pedido por los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnJuego_Click(object sender, EventArgs e)
        {
            rtbHistorial.Text = MostrarJuegoFavoritoClientes();
        }

        /// <summary>
        /// Muestra los equipos ordenados de forma descendente con el criterio de minutos de uso.
        /// Se utiliza en el historial del programa.
        /// </summary>
        /// <param name="t"></param>
        /// <returns>Imprime la lista de equipos ordenados por minutos de uso en forma descendente</returns>
        public static string OrdenamientoDecendenteTiempo(TipoEquipo t)
        {
            StringBuilder sb = new();
            List<Equipo> e = new();
            foreach (Equipo equipo in Usuario.Lista)
            {
                if (t == TipoEquipo.Cabina && equipo is Telefono)
                {
                    e.Add(equipo);
                }
                else if (t == TipoEquipo.Computadora && equipo is Computadora)
                {
                    e.Add(equipo);
                }
            }
            e.Sort(CompararEquipo);
            foreach (Equipo equipo in e)
            {
                sb.AppendLine($"------------------------------------------------------------------");
                sb.AppendLine($"{equipo}\n");
                sb.AppendLine($"------------------------------------------------------------------");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Calcula las ganancias totales y las clasifica por servicio (Computadora/telefono).
        /// Se utiliza en el historial del programa.
        /// summary>
        /// <returns>Devuelve la informacion de las ganancias totales, de las ganancias del servicio de computadoras y de las ganancias del servicio de telefonos</returns>
        public static string CalcularGanancias()
        {
            StringBuilder sb = new();
            float gananciasComputadoras = 0;
            float gananciasTelefonos = 0;
            foreach (Equipo e in Usuario.Lista)
            {
                if (e.Lista.Count > 0)
                {
                    foreach (Servicio s in e.Lista)
                    {
                        if (s is ClienteComputadora)
                        {
                            gananciasComputadoras += s.Costo;
                        }
                        else
                        {
                            gananciasTelefonos += s.Costo;
                        }
                    }
                }
            }
            sb.AppendLine($"GANANCIAS TOTALES: $ {(gananciasComputadoras + gananciasTelefonos)}\n");
            sb.AppendLine($"GANANCIAS DE COMPUTADORAS: $ {gananciasComputadoras}\n");
            sb.AppendLine($"GANANCIAS DE TELEFONOS: $ {gananciasTelefonos}\n");
            return sb.ToString();
        }
        /// <summary>
        /// Calcula el total de horas que se uso en los equipos y tambien el costo de cada tipo de llamadas(local/larga distancia/internacional)
        /// Se utiliza en el historial del programa.
        /// </summary>
        /// <returns></returns>
        public static string CalcularHorasYRecaudacion()
        {
            int duracionTotal = 0;
            double local = 0;
            double largaDistancia = 0;
            double internacional = 0;
            foreach (Equipo e in Usuario.Lista)
            {
                foreach (Servicio s in e.Lista)
                {
                    if (s is not null)
                    {
                        duracionTotal += s.Duracion;
                    }
                }
                foreach (Servicio s in e.Lista)
                {
                    if (s is ClienteTelefono t)
                    {
                        if (t.Tipo == TipoLocalidad.Local)
                        {
                            local += s.Costo;
                        }
                        if (t.Tipo == TipoLocalidad.LargaDistancia)
                        {
                            largaDistancia += s.Costo;
                        }
                        if (t.Tipo == TipoLocalidad.Internacional)
                        {
                            internacional += s.Costo;
                        }
                    }
                }
            }
            StringBuilder sb = new();
            sb.AppendLine($"HORAS TOTALES: {duracionTotal / 60}");
            sb.AppendLine($"RECAUDACION POR LLAMADAS DE TIPO LOCAL: ${local}\n");
            sb.AppendLine($"RECAUDACION POR LLAMADAS DE TIPO LARGA DISTANCIA: ${largaDistancia}\n");
            sb.AppendLine($"RECAUDACION POR LLAMADAS DE TIPO INTERNACIONAL: ${internacional}\n");
            return sb.ToString();
        }
        /// <summary>
        /// Muestra el software mas pedido por los clientes.
        /// Se utiliza en el historial del programa.
        /// </summary>
        /// <returns></returns>
        public static string MostrarSoftwareFavoritoClientes()
        {
            int cont = 0;
            string softwareFavorito = string.Empty;
            Dictionary<string, int> software = new();
            foreach (Servicio s in ListaEquipos())
            {
                if (s is ClienteComputadora c)
                {
                    foreach (Software i in c.Software)
                    {
                        if (!software.ContainsKey(i.ToString()))
                        {
                            software.Add(i.ToString(), 1);
                        }
                        else
                        {
                            software[i.ToString()] += 1;
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, int> s in software)
            {
                if (s.Value > cont)
                {
                    softwareFavorito = s.Key;
                    cont = s.Value;
                }
            }
            if (!string.IsNullOrEmpty(softwareFavorito))
            {
                return $"EL SOFTWARE MAS PEDIDO POR LOS CLIENTES ES: {softwareFavorito}\n";
            }
            else
            {
                return $"NO HAY SOFTWARE MAS PEDIDOS.\n";
            }
        }
        /// <summary>
        /// Muestra el periferico mas pedido por los clientes.
        /// Se utiliza en el historial del programa.
        /// </summary>
        /// <returns></returns>
        public static string MostrarPerifericoFavoritoClientes()
        {
            int cont = 0;
            string perifericoFavorito = string.Empty;
            Dictionary<string, int> periferico = new();
            foreach (Servicio s in ListaEquipos())
            {
                if (s is ClienteComputadora c)
                {
                    foreach (Periferico i in c.Periferico)
                    {
                        if (!periferico.ContainsKey(i.ToString()))
                        {
                            periferico.Add(i.ToString(), 1);
                        }
                        else
                        {
                            periferico[i.ToString()] += 1;
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, int> s in periferico)
            {
                if (s.Value > cont)
                {
                    perifericoFavorito = s.Key;
                    cont = s.Value;
                }
            }
            if (!string.IsNullOrEmpty(perifericoFavorito))
            {
                return $"EL PERIFERICO MAS PEDIDO POR LOS CLIENTES ES: {perifericoFavorito}\n";
            }
            else
            {
                return $"NO HAY PERIFERICOS MAS PEDIDOS.\n";
            }
        }
        /// <summary>
        /// Muestra el juego mas pedido por los clientes.
        /// Se utiliza en el historial del programa.
        /// </summary>
        /// <returns></returns>
        public static string MostrarJuegoFavoritoClientes()
        {
            int cont = 0;
            string juegoFavorito = string.Empty;
            Dictionary<string, int> juego = new();
            foreach (Servicio s in ListaEquipos())
            {
                if (s is ClienteComputadora c)
                {
                    foreach (Juego i in c.Juego)
                    {
                        if (!juego.ContainsKey(i.ToString()))
                        {
                            juego.Add(i.ToString(), 1);
                        }
                        else
                        {
                            juego[i.ToString()] += 1;
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, int> s in juego)
            {
                if (s.Value > cont)
                {
                    juegoFavorito = s.Key;
                    cont = s.Value;
                }
            }
            if (!string.IsNullOrEmpty(juegoFavorito))
            {
                return $"EL JUEGO MAS PEDIDO POR LOS CLIENTES ES: {juegoFavorito}\n";
            }
            else
            {
                return $"NO HAY JUEGOS MAS PEDIDOS.\n";
            }
        }

        /// <summary>
        /// Compara dos equipos segun sus minutos de uso.
        /// Esta funcion se usa para el ordanamiento descendente de equipos segun el tiempo de uso.
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns>1 si p1 es mayor a p2, 0 si son iguales, -1 si es menor</returns>
        internal static int CompararEquipo(Equipo e1, Equipo e2)
        {
            return e2.Minutos.CompareTo(e1.Minutos);
        }
        /// <summary>
        /// Lista todos los equipos del usuario.
        /// </summary>
        /// <returns>Lista de sesiones</returns>
        private static List<Servicio> ListaEquipos()
        {
            List<Servicio> s = new();

            foreach (Equipo e in Usuario.Lista)
            {
                foreach (Servicio serv in e.Lista)
                {
                    s.Add(serv);
                }
            }
            return s;
        }
    }
}
