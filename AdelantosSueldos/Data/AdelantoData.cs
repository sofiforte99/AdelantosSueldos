using AdelantosSueldos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Data
{
    //Todo el modelo de data se creará para luego pasarse al modelo de negocio
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

        //trae adelantos
        public List<Adelanto> GetAdelantos()
        {
            return listadoAdelantos;
        }

        //guarda
        public void GuardarAdelanto(Adelanto adelanto)
        {
            this.listadoAdelantos.Add(adelanto);
        }

        //borra
        public void BorrarAdelanto(Adelanto adelanto)
        {
            var adelantoItem = this.listadoAdelantos.FirstOrDefault(a => a.Codigo == adelanto.Codigo);
            this.listadoAdelantos.Remove(adelantoItem);
        }

        public void ActualizarAdelanto(Adelanto adelanto)
        {
            var adelantoItem = this.listadoAdelantos.FirstOrDefault(a => a.Codigo == adelanto.Codigo);
            this.listadoAdelantos.Remove(adelantoItem);
            this.listadoAdelantos.Add(adelantoItem);
        }


        public void ActualizarImporte(Adelanto adelanto)
        {
            var adelantoPago = this.listadoAdelantos.FirstOrDefault(p => p.ImportePagado == adelanto.ImportePagado);
            this.listadoAdelantos.Remove(adelantoPago);
            this.listadoAdelantos.Add(adelantoPago);
        }
        //toma adelantos por empleado a través de expresión lanmbda
        public List<Adelanto> GetAdelantosxEmpleado(string legajo)
        {
            return listadoAdelantos.Where(l => l.Beneficiario.Legajo != null && l.Beneficiario.Legajo == legajo).ToList();
        }
    }
}

