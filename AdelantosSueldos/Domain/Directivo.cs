using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Domain
{
    public class Directivo : Empleado
    {
        public override decimal PorcentajeBeneficio
        {
            get => 0.01m;
        }
    }
}
