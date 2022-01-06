using System;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private readonly int dni;
        private readonly string nombre;
        private readonly string apellido;
        private readonly short edad;
        private Servicio servicio;

        /// <summary>
        /// Constructor de la clase Cliente
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="servicio"></param>
        public Cliente(int dni, string nombre, string apellido, short edad, Servicio servicio)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.servicio = servicio;
        }

        /// <summary>
        /// Propiedad de Servicio.
        /// </summary>
        public Servicio Servicio
        {
            get
            {
                return servicio;
            }
        }

        /// <summary>
        /// Operador + para agregar un cliente a un servicio(Telefono/Computadora).
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Cliente operator +(Cliente c, Servicio s)
        {
            if (s is ClienteTelefono telefono)
            {
                c.servicio = telefono;
            }
            else
            {
                c.servicio = (ClienteComputadora)s;

            }
            return c;
        }
        /// <summary>
        /// Operador == (Igual) para comparar el DNI del cliente.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1 is not null && c2 is not null)
            {
                return c1.dni == c2.dni;
            }
            return false;
        }
        /// <summary>
        /// Operador != (distinto) para la comparacion del DNI de cliente si son diferentes.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals().
        /// Requerible para el operador == (igual).
        /// </summary>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Cliente c = obj as Cliente;
            return c != null && this == c;
        }
        /// <summary>
        /// Sobrecarga del metodo GetHashCode().
        /// Requerible para el operado != (distinto).
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString()
        /// Imprime los datos del cliente.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"- Nombre: {nombre} \n");
            sb.AppendLine($"- Apellido: {apellido} \n");
            sb.AppendLine($"- DNI: {dni} \n");
            sb.AppendLine($"- Edad: {edad} años \n");
            return sb.ToString();
        }
    }
}
