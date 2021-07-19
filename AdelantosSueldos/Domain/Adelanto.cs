using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Domain
{
    public class Adelanto
    {
        public string Codigo { get; set; }
        public DateTime FechaDeOtorgamiento { get; set; }
        public DateTime? FechaDeCancelacion { get; set; }
        public decimal ImporteOtorgado { get; set; }
        public decimal ImportePagado { get; set; }
        public decimal Beneficio { get; set; }
        public decimal SaldoAdeudado { get; set; }
        public Empleado Beneficiario { get; set; }

        public Empleado Pago { get; set; }
    }
}
