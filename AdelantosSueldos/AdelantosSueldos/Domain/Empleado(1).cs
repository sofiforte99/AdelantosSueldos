using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Domain
{
    public abstract class Empleado
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Sueldo { get; set; }
        public abstract decimal PorcentajeBeneficio { get; }
    }
}
