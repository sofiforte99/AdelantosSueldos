using AdelantosSueldos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Data
{
    public class AdelantoData
    {
        private List<Adelanto> listadoAdelantos = new List<Adelanto>();

        public AdelantoData()
        {
            listadoAdelantos.Add(new Adelanto()
            {
                 Codigo = "AA",
                 FechaDeOtorgamiento = DateTime.Now,
                 FechaDeCancelacion = null,
                 ImporteOtorgado = 100000,
                 ImportePagado = 0,
                 SaldoAdeudado = 100000,
                 Beneficio = 0
            });
        }

        public List<Adelanto> GetAdelantos()
        {
            return listadoAdelantos;
        }

        public void GuardarAdelanto(Adelanto adelanto)
        {
            this.listadoAdelantos.Add(adelanto);
        }

        public void ActualizarAdelanto(Adelanto adelanto)
        {
            var adelantoItem = this.listadoAdelantos.FirstOrDefault(l => l.Codigo == adelanto.Codigo);
            this.listadoAdelantos.Remove(adelantoItem);
            this.listadoAdelantos.Add(adelantoItem);
        }

        public List<Adelanto> GetAdelantosxEmpleado(string legajo)
        {
            return listadoAdelantos.Where(l => l.Beneficiario != null && l.Beneficiario.Legajo == legajo).ToList();
        }

        public void BorrarAdelanto (Adelanto adelanto)
        {
            this.listadoAdelantos.Remove(adelanto);
        }
}
}
