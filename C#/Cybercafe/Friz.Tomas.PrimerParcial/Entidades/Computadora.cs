using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Computadora: Equipo
    {
        private readonly List<Software> software;
        private readonly List<Periferico> perifericos;
        private readonly List<Juego> juegos;
        private readonly Dictionary<Hardware, string> hardware;

        /// <summary>
        /// Constructor de la clase de Computadora para los componentes del mismo.
        /// </summary>
        private Computadora(string id): base(id)
        {
            software = new List<Software>();
            perifericos = new List<Periferico>();
            juegos = new List<Juego>();
            hardware = new Dictionary<Hardware, string>();
        }
        /// <summary>
        /// Constructor de Computadora en general(con todos los datos y especificaciones).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="software"></param>
        /// <param name="perifericos"></param>
        /// <param name="juegos"></param>
        /// <param name="hardware"></param>
        public Computadora(string id, List<Software> software,List<Periferico> perifericos, List<Juego> juegos,Dictionary<Hardware, string> hardware): this(id)
        {
            this.id = id;
            this.tipo = TipoEquipo.Computadora;
            this.software = software;
            this.perifericos = perifericos;
            this.juegos = juegos;
            this.hardware = hardware;
        }

        /// <summary>
        /// Propiedad del Enumerado de Software de software.
        /// </summary>
        public List<Software> Software
        {
            get
            {
                return software;
            }
        }
        /// <summary>
        /// Indexador para el Enumerado de Hardware.
        /// </summary>
        /// <param name="h"></param>
        /// <returns>Retorna las especificaciones de hardware que contiene cada computadora.</returns>
        public string this[Hardware h]
        {
            get
            {
                return hardware[h];
            }
        }
        /// <summary>
        /// Propiedad del Enumerado de Periferico de perifericos.
        /// </summary>
        public List<Periferico> Perifericos
        {
            get
            {
                return perifericos;
            }
        }
        /// <summary>
        /// Propiedad del Enumerado de Juego de juegos.
        /// </summary>
        public List<Juego> Juegos
        {
            get
            {
                return juegos;
            }
        }

        /// <summary>
        /// Operador == (igual) para comparar que el software este instalado en la computadora.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c, Software s)
        {
            if (c.Software.Count > 0)
            {
                foreach (Software software in c.Software)
                {
                    if (software == s)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Operador != (distinto) para comparar que el software no este instalado en la computadora.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora c, Software s)
        {
            return !(c == s);
        }
        /// <summary>
        /// Operador == (igual) para compara que el periferico este disponible en la computadora.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c, Periferico p)
        {
            if (c.Perifericos.Count > 0)
            {
                foreach (Periferico periferico in c.Perifericos)
                {
                    if (periferico == p)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Operador != (distinto) para comparar que el periferico no este disponible en la computadora.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora c, Periferico p)
        {
            return !(c == p);
        }
        /// <summary>
        /// Operador == (igual) para compara que el juego este instalado en la computadora.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c, Juego j)
        {
            if (c.Juegos.Count > 0)
            {
                foreach (Juego juego in c.Juegos)
                {
                    if (juego == j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Operador != (distinto) para comparar que el juego no este instalado en la computadora.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora c, Juego j)
        {
            return !(c == j);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals().
        /// Requerido para el operador == (igual).
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Computadora c = obj as Computadora;
            return c != null && this == c;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode().
        /// Requerido para el operador != (distinto).
        /// Reutilisacion de la base de GetHashCode().
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString().
        /// Imprime los datos de la computadora, incluyendo el costo por minuto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"\nSOFTWARE: ");
            foreach (Software software in software)
            {
                sb.AppendLine($"{software}");
            }
            sb.AppendLine($"\nPERIFERICOS: ");
            foreach (Periferico periferico in perifericos)
            {
                sb.AppendLine($"{periferico}");
            }
            sb.AppendLine($"\nJUEGOS: ");
            foreach (Juego juego in juegos)
            {
                sb.AppendLine($"{juego}");
            }
            sb.AppendLine($"\nHARDWARE: ");
            sb.AppendLine($"RAM: {this[Hardware.RAM]}");
            sb.AppendLine($"Placa de video: {this[Hardware.placaVideo]}");
            sb.AppendLine($"Procesador: {this[Hardware.procesador]}");
            return sb.ToString();
        }
    }
}
