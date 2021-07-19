using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Domain
{
    public class Administrativo : Empleado
    {
        public override decimal PorcentajeBeneficio
        {
            get => 0.05m;
        }
    }
}
