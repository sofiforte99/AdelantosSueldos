using AdelantosSueldos.Business;
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
    public partial class frmAdelantos : Form
    {
        private EmpleadoBusiness empleadoBusiness = new EmpleadoBusiness();
        private AdelantoBusiness adelantoBusiness = new AdelantoBusiness();

        public frmAdelantos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEdicionEmpleado frmEdicionEmpleado = new frmEdicionEmpleado();
            frmEdicionEmpleado.ShowDialog();

            var empleado = frmEdicionEmpleado.Empleado;
            empleadoBusiness.GuardarEmpleado(empleado);

            CargarDatosEmpleados();

        }

        private void CargarDatosEmpleados()
        {
            BindingSource source = new BindingSource();

            var empleados = this.empleadoBusiness.GetEmpleados();
            source.DataSource = empleados;

            this.dgvEmpleados.DataSource = source;
        }

        private void CargarDatosAdelantos()
        {
            BindingSource source = new BindingSource();

            var adelantos = this.adelantoBusiness.GetAdelantos();
            source.DataSource = adelantos;

            this.dgvAdelantos.DataSource = source;
        }

        private void CargarDatosAdelantosEmpleados(string legajo)
        {
            BindingSource source = new BindingSource();

            var adelantos = this.adelantoBusiness.GetAdelantosxEmpleado(legajo);
            source.DataSource = adelantos;

            this.dgvAdelantosEmpleado.DataSource = source;
        }

        private void frmAdelantos_Load(object sender, EventArgs e)
        {
            CargarDatosEmpleados();
            CargarDatosAdelantos();
        }

        private void btnAsociarAdelantoEmpleado_Click(object sender, EventArgs e)
        {
            var empleadoSeleccionado = this.dgvEmpleados.SelectedRows[0].DataBoundItem as Empleado;
            var adelantoSeleccionado = this.dgvAdelantos.SelectedRows[0].DataBoundItem as Adelanto;

            adelantoSeleccionado.Beneficiario = empleadoSeleccionado;
            this.adelantoBusiness.ActualizarAdelanto(adelantoSeleccionado);

            MessageBox.Show("Se asocio el adelanto con el empleado");

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var empleado = this.dgvEmpleados.Rows[e.RowIndex].DataBoundItem as Empleado;
            CargarDatosAdelantosEmpleados(empleado.Legajo);
        }

        private void dgvAdelantosEmpleado_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvAdelantosEmpleado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
