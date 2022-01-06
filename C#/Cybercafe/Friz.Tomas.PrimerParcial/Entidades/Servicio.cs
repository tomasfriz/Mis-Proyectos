using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Servicio
    {
        protected int duracion;
        protected DateTime inicio;

        /// <summary>
        /// Propiedad de Duracion.
        /// </summary>
        abstract public int Duracion 
        { 
            get; 

            set; 
        }
        /// <summary>
        /// Propiedad de Costo, devuelve el calculo del costo del servicio.
        /// </summary>
        public float Costo
        {
            get
            {
                return CalcularCosto();
            }
        }
        /// <summary>
        /// Propiedad del DateTime de inicio, establece el comienzo del tiempo del servicio dado.
        /// </summary>
        public DateTime Inicio
        {
            get
            {
                return inicio;
            }
            set
            {
                inicio = value;
            }
        }

        /// <summary>
        /// Operador == (igual) para comparar si los servicios son iguales.
        /// Reutilizacion del metodo de GetHashCode().
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator ==(Servicio s1, Servicio s2)
        {
            return (s1 is not null && s2 is not null) && s1.GetHashCode() == s2.GetHashCode();
        }
        /// <summary>
        /// Operador != (distinto) para comparar si los servicios son distintos.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator !=(Servicio s1, Servicio s2)
        {
            return !(s1 == s2);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals().
        /// Requerido para el operador == (igual).
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Servicio s = obj as Servicio;
            return s != null && this == s;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode().
        /// Requerido para el operador != (distinto).
        /// Reutilizacion del metodo GetType() para devolver el tipo de tiempo de ejecucion exacto.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (Inicio,GetType(),Duracion).GetHashCode();
        }

        /// <summary>
        /// Calcula el costo del servicio.
        /// </summary>
        /// <returns></returns>
        abstract protected float CalcularCosto();
        /// <summary>
        /// Agrega un 21% del IVA al costo del servicio.
        /// </summary>
        /// <returns></returns>
        public float AgregarIVA()
        {
            return Costo * 1.21F;
        }
    }
}
