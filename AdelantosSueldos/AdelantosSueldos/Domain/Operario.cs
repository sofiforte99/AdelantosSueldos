﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Domain
{
    public class Operario : Empleado
    {
        public override decimal PorcentajeBeneficio {
            get => 0.10m;
        }
    }
}
