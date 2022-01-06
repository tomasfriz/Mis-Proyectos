using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string id;
        protected Estado estado;
        protected TipoEquipo tipo;
        protected List<Servicio> lista;

        /// <summary>
        /// Constructor de la clase Equipo.
        /// </summary>
        /// <param name="id"></param>
        protected Equipo(string id)
        {
            this.id = id;
            this.lista = new List<Servicio>();
            this.estado = Estado.Disponible;
        }

        /// <summary>
        /// Propiedad de id.
        /// </summary>
        public string Id
        {
            get
            {
                return id;
            }
        }
        /// <summary>
        /// Propiedad de Minutos, Devuelve los minutos de los equipos en uso.
        /// </summary>
        public int Minutos
        {
            get
            {
                return CalcularMinutos();
            }
        }
        /// <summary>
        /// Propiedad del Enumerado de Estado de estado.
        /// </summary>
        public Estado Estado
        {
            get
            {
                return estado;
            }
            set
            {
                this.estado = value;
            }
        }
        /// <summary>
        /// Propiedad del Enumerado de TipoEquipo de tipo.
        /// </summary>
        public TipoEquipo Tipo
        {
            get
            {
                return tipo;
            }
        }
        /// <summary>
        /// Propiedad de la lista de Servicio de lista.
        /// </summary>
        public List<Servicio> Lista
        {
            get
            {
                return lista;
            }
        }

        /// <summary>
        /// Operador == (igual) para comparar si los equipos son iguales.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo t1,Equipo t2)
        {
            if (t1 is not null && t2 is not null)
            {
                return t1.id == t2.id;
            }
            return false;
        }
        /// <summary>
        /// Operador != (distinto) para comparar si los equipos son distintos.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator !=(Equipo t1, Equipo t2)
        {
            return !(t1 == t2);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals().
        /// Requerido para el operador == (igual).
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Equipo t = obj as Equipo;
            return t != null && this == t;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode().
        /// Requerido para el operador != (distinto).
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        /// <summary>
        /// Calcula los minutos de uso del equipo mas la duracion del mismo.
        /// </summary>
        /// <returns>Minutos de uso</returns>
        protected int CalcularMinutos()
        {
            int total = 0;
            foreach (Servicio s in lista)
            {
                total += s.Duracion;
            }
            return total;
        }
        /// <summary>
        /// Sobrescribe el metodo ToString().
        /// Imprime el tipo de equipo(computadora/telefono), el id del mismo, el estado (Libre/En_Uso) y la duracion en minutos del tiempo de uso del mismo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"\nID: {id}");
            sb.AppendLine($"\nTIPO: {tipo}");
            sb.AppendLine($"\nESTADO: {estado}");
            sb.AppendLine($"\nMINUTOS: {Minutos}");
            return sb.ToString();
        }
    }
}
