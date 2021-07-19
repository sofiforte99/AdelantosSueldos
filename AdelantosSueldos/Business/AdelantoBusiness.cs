using AdelantosSueldos.Data;
using AdelantosSueldos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Business
{
    //Lógica de negocio, trae elementos de la data
    public class AdelantoBusiness
    {
        private AdelantoData adelantoData = new AdelantoData();

        public List<Adelanto> GetAdelantos()
        {
            return this.adelantoData.GetAdelantos();
        }
        public void BorrarAdelanto(Adelanto adelanto)
        {
            this.adelantoData.BorrarAdelanto(adelanto);
        }

        public void GuardarAdelanto(Adelanto adelanto)
        {
            this.adelantoData.GuardarAdelanto(adelanto);
        }

        public void ActualizarAdelanto(Adelanto adelanto)
        {
            this.adelantoData.ActualizarAdelanto(adelanto);
        }

        public void ActualizarImporte (Adelanto adelanto)
        {
            this.adelantoData.ActualizarImporte(adelanto);
        }
        public List<Adelanto> GetAdelantosxEmpleado(string legajo)
        {
            return this.adelantoData.GetAdelantosxEmpleado(legajo);
        }
    }
}
