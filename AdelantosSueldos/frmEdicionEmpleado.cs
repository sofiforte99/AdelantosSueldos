using AdelantosSueldos.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdelantosSueldos
{
    public partial class frmEdicionEmpleado : Form
    {
        public Empleado Empleado = null;

        public frmEdicionEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch(this.cmbCategoria.Text)
            {
                case "Operario":
                    Empleado = new Operario();
                    break;
                case "Administrativo":
                    Empleado = new Administrativo();
                    break;
                case "Directivo":
                    Empleado = new Directivo();
                    break;
            }

            this.Empleado.Nombre = this.txtNombre.Text;
            this.Empleado.Apellido = this.txtApellido.Text;
            this.Empleado.Legajo = this.txtLegajo.Text;
            this.Empleado.Sueldo = decimal.Parse(this.txtSueldo.Text);
            this.Close();
        }
    }
}
