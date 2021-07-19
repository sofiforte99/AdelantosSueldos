using AdelantosSueldos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdelantosSueldos.Data
{
    public class EmpleadoData
    {
        private List<Empleado> listadoEmpleados = new List<Empleado>();

        public EmpleadoData()
        {
            listadoEmpleados.Add(new Operario()
            {
                 Legajo = "1",
                 Nombre = "Pepe",
                 Apellido = "Gomez",
                 Sueldo = 500000
            });
        }

        public List<Empleado> GetEmpleados()
        {
            return listadoEmpleados;
        }

        public void GuardarEmpleado(Empleado empleado)
        {
            this.listadoEmpleados.Add(empleado);
        }
    }
}
