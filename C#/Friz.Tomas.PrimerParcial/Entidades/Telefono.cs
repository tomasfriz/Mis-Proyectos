using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Telefono : Equipo
    {
        private readonly TipoTecla tipoTecla;
        private readonly string marca;

        /// <summary>
        /// Constructor de la clase telefono.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipoTecla"></param>
        /// <param name="marca"></param>
        public Telefono(string id, TipoTecla tipoTecla, string marca): base(id)
        {
            this.id = id;
            this.tipoTecla = tipoTecla;
            this.marca = marca;
            this.tipo = TipoEquipo.Cabina;
        }

        /// <summary>
        /// Sobrescribe el metodo ToString().
        /// Imprime los datos del telefono.
        /// Reutilizacion de la base de ToString.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"\nESTILO DE TECLA: {tipoTecla}");
            sb.AppendLine($"\nMARCA: {marca}");
            return sb.ToString();
        }
    }
}
