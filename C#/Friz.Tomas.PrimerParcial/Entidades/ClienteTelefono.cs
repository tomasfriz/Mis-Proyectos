using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class ClienteTelefono : Servicio
    {
        private string codigo;
        private string localidad;
        private string num;

        /// <summary>
        /// Propiedad de NumDestino y devuelve el numero de destino.
        /// </summary>
        public string NumDestino
        {
            get
            {
                return $"+{codigo} ({localidad}) {num}";
            }
        }
        /// <summary>
        /// Propiedad del Enumerado de Tipo de Tipo y devuelve el tipo de localidad.
        /// </summary>
        public TipoLocalidad Tipo
        {
            get
            {
                return IdentificarLocalidad();
            }
        }
        /// <summary>
        /// Propiedad de Duracion.
        /// </summary>
        public override int Duracion
        {
            get
            {
                return duracion;
            }
            set
            {
                this.duracion = value;
            }
        }
        /// <summary>
        /// Propiedad de codigo.
        /// </summary>
        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        /// <summary>
        /// Propiedad de Localidad.
        /// </summary>
        public string Localidad
        {
            get
            {
                return localidad;
            }
            set
            {
                localidad = value;
            }
        }

        /// <summary>
        /// Propiedad de Num.
        /// </summary>
        public string Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        /// <summary>
        /// Operador == (igual) para comparar los datos del ClienteTelefono (Se reutiliza el metodo de GetHashCode).
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(ClienteTelefono c1, ClienteTelefono c2)
        {
            if (c1 is not null && c2 is not null)
            {
                return c1.GetHashCode() == c2.GetHashCode();
            }
            return false;
        }
        /// <summary>
        /// Operador != (distinto) para la comparacion del ClienteTelefono si son distintos.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(ClienteTelefono c1, ClienteTelefono c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals().
        /// Requerido para el operador == (igual).
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            ClienteTelefono c = obj as ClienteTelefono;
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
            return base.GetHashCode() + NumDestino.GetHashCode();
        }

        /// <summary>
        /// Calcula el costo de la llamada segun su duracion y el tipo de valor del minuto.
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCosto()
        {
            return (Duracion * (int)Tipo) / 100;
        }
        /// <summary>
        /// Determina si el numero es local, Provincial o internacional.
        /// </summary>
        /// <returns>Tipo de llamada</returns>
        private TipoLocalidad IdentificarLocalidad()
        {
            if (codigo != "54")
            {
                return TipoLocalidad.Internacional;
            }
            else
            {
                if (localidad == "011" || localidad == "11")
                {
                    return TipoLocalidad.Local;
                }
                else
                {
                    return TipoLocalidad.LargaDistancia;
                }
            }
        }
    }
}
