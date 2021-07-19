using AdelantosSueldos.Data;
using AdelantosSueldos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Business
{   
    public class EmpleadoBusiness
    {
        private EmpleadoData empleadoData = new EmpleadoData();

        public List<Empleado> GetEmpleados()
        {
            return this.empleadoData.GetEmpleados();
        }

        public void GuardarEmpleado(Empleado empleado)
        {
            this.empleadoData.GuardarEmpleado(empleado);
        }
    }
}
