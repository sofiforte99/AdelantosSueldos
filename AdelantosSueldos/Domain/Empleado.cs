using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Domain
{

    public abstract class Empleado
    {
        //atributos
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Sueldo { get; set; }
        public abstract decimal PorcentajeBeneficio { get; }

        //para que visualice el nombre y el apellido del empleado
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
