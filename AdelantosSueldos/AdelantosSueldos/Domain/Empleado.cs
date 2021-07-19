using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Domain
{
    public class Empleado
    {
        public Empleado()
        {
        }

        public Empleado(string legajo, string nombre, string apellido, decimal sueldo, decimal porcentajeBeneficio)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Sueldo = sueldo;
            PorcentajeBeneficio = porcentajeBeneficio;
        }

     

        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Sueldo { get; set; }
        public decimal PorcentajeBeneficio { get;}
    }
}
