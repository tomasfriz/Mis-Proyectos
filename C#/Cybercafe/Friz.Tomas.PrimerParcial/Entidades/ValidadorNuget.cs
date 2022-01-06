using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Entidades
{
    /// <summary>
    /// Uso este paquete nuget FluentValidation porque es un paquete muy popular en temas de validacion y ademas muy completo.
    /// Resuelve hasta los dolores de cabeza jajaja XD.
    /// </summary>
    public class ValidadorNuget : AbstractValidator<ClienteTelefono>
    {
        /// <summary>
        /// Valida que los números ingresados sean correctos con los parametros del paquete nuget, caso contrario salta error mas un mensaje descriptivo.
        /// </summary>
        public ValidadorNuget()
        {
            RuleFor(x => x.Codigo).NotEmpty().MaximumLength(4).Matches("^[0-9]*$").WithMessage("El código regional no es válido, reingrese los datos otra ves\n");
            RuleFor(x => x.Localidad).NotEmpty().MinimumLength(2).MaximumLength(5).Matches("^[0-9]*$").WithMessage("El codigo de localidad no es válido, reingrese los datos otra ves\n");
            RuleFor(x => x.Num).NotEmpty().MinimumLength(6).MaximumLength(8).Matches("^[0-9]*$").WithMessage("El número telefonico no es válido, reingrese los datos otra ves\n");
        }
    }
}
