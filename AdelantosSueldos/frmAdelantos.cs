using AdelantosSueldos.Business;
using AdelantosSueldos.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdelantosSueldos
{
    public partial class frmAdelantos : Form
    {
        public Empleado Empleado = null;
        public Adelanto Adelanto = new Adelanto();
        private EmpleadoBusiness empleadoBusiness = new EmpleadoBusiness();
        private AdelantoBusiness adelantoBusiness = new AdelantoBusiness();

        public frmAdelantos()
        {
            InitializeComponent();
        }

      

        //Realiza carga de empleados tomándolos del modelo de negocio

        private void CargarDatosEmpleados()
        {
            BindingSource source = new BindingSource();

            var empleados = this.empleadoBusiness.GetEmpleados();
            source.DataSource = empleados;

            this.dgvEmpleados.DataSource = source;
        }

        //Realiza carga de adelantos a través del modelo de negocio

        private void CargarDatosAdelantos()
        {
            BindingSource source = new BindingSource();

            var adelantos = this.adelantoBusiness.GetAdelantos();
            source.DataSource = adelantos;

            this.dgvAdelantos.DataSource = source;
        }

        //Realiza carga de adelantos por empleado vinculandolos a través del legajo
        private void CargarDatosAdelantosEmpleados(string legajo)
        {
            BindingSource source = new BindingSource();
            var adelantos = this.adelantoBusiness.GetAdelantosxEmpleado(legajo);
            source.DataSource = adelantos;

            this.dgvAdelantosEmpleado.DataSource = source;
        }

        //Carga de datos al formulario 

        private void frmAdelantos_Load(object sender, EventArgs e)
        {
            CargarDatosEmpleados();
            CargarDatosAdelantos();
        }

        //Asocia el adelanto a los empleados
        private void btnAsociarAdelantoEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                var empleadoSeleccionado = this.dgvEmpleados.SelectedRows[0].DataBoundItem as Empleado;
                var adelantoSeleccionado = this.dgvAdelantos.SelectedRows[0].DataBoundItem as Adelanto;

                adelantoSeleccionado.Beneficiario = empleadoSeleccionado;
                this.adelantoBusiness.ActualizarAdelanto(adelantoSeleccionado);

                MessageBox.Show("Se asocio el adelanto con el empleado");

                CargarDatosAdelantosEmpleados(empleadoSeleccionado.Legajo);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        // Cargar los txtBox con los valores de las celdas del grid
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*var empleado = this.dgvEmpleados.Rows[e.RowIndex].DataBoundItem as Empleado;
            CargarDatosAdelantosEmpleados(empleado.Legajo);*/
            txtLegajo.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtSueldo.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            cmbCategoria.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
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

        //Guarda los datos tomando en cuenta las categorías del combobox
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.cmbCategoria.Text)
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

                this.Empleado.Legajo = this.txtLegajo.Text;
                this.Empleado.Nombre = this.txtNombre.Text;
                this.Empleado.Apellido = this.txtApellido.Text;
                this.Empleado.Sueldo = decimal.Parse(this.txtSueldo.Text);

                empleadoBusiness.GuardarEmpleado(Empleado);

                CargarDatosEmpleados();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Elimina Empleados
        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell clienteCell in dgv.SelectedCells)
                {
                    if (clienteCell.Selected)
                        dgvClientes.Rows.RemoveAt(clienteCell.RowIndex);
                }
            }
            catch (Exception)
            {

                throw;
            } 
           
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.cmbCategoria.Text)
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

                this.Empleado.Legajo = this.txtLegajo.Text;
                this.Empleado.Nombre = this.txtNombre.Text;
                this.Empleado.Apellido = this.txtApellido.Text;
                this.Empleado.Sueldo = decimal.Parse(this.txtSueldo.Text);

                empleadoBusiness.ActualizarEmpleado(Empleado);

                CargarDatosEmpleados();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnAgregarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.cmbBeneficio.Text)
                {
                    case "Operario":
                        this.Adelanto.Beneficio = 0.10m;
                        break;
                    case "Administrativo":
                        this.Adelanto.Beneficio = 0.05m;
                        break;
                    case "Directivo":
                        this.Adelanto.Beneficio = 0.01m;
                        break;
                }

                this.Adelanto.Codigo = this.txtCodigo.Text;
                this.Adelanto.FechaDeOtorgamiento = this.dtpFechaOtorgamiento.Value;
                this.Adelanto.FechaDeCancelacion = this.dtpFechaCancelacion.Value;
                this.Adelanto.ImporteOtorgado = decimal.Parse(this.txtImporteOtorgado.Text);
                this.Adelanto.ImportePagado = decimal.Parse(this.txtImportePagado.Text);
                this.Adelanto.SaldoAdeudado = decimal.Parse(this.txtSaldoAdeudado.Text);

                adelantoBusiness.GuardarAdelanto(Adelanto);

                CargarDatosAdelantos();
            }
            catch (Exception)
            {

                throw;
            }
            

           
        }
        //Borra adelanto
        private void btnBorrarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAdelantos.Rows.RemoveAt(dgvAdelantos.SelectedRows[0].Index);
                adelantoBusiness.BorrarAdelanto(Adelanto);
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        //Editar adelanto
        private void btnEditarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.cmbBeneficio.Text)
                {
                    case "Operario":
                        this.Adelanto.Beneficio = 0.10m;
                        break;
                    case "Administrativo":
                        this.Adelanto.Beneficio = 0.05m;
                        break;
                    case "Directivo":
                        this.Adelanto.Beneficio = 0.01m;
                        break;
                }

                this.Adelanto.Codigo = this.txtCodigo.Text;
                this.Adelanto.FechaDeOtorgamiento = this.dtpFechaOtorgamiento.Value;
                this.Adelanto.FechaDeCancelacion = this.dtpFechaCancelacion.Value;
                this.Adelanto.ImporteOtorgado = decimal.Parse(this.txtImporteOtorgado.Text);
                this.Adelanto.ImportePagado = decimal.Parse(this.txtImportePagado.Text);
                this.Adelanto.SaldoAdeudado = decimal.Parse(this.txtSaldoAdeudado.Text);

                adelantoBusiness.ActualizarAdelanto(Adelanto);

                CargarDatosAdelantos();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void dgvAdelantos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpFechaCancelacion.Enabled = true;

            txtCodigo.Text = dgvAdelantos.CurrentRow.Cells[0].Value.ToString();
            dtpFechaOtorgamiento.Text = dgvAdelantos.CurrentRow.Cells[1].Value.ToString();
            dtpFechaCancelacion.Text = dgvAdelantos.CurrentRow.Cells[2].Value?.ToString();
            txtImporteOtorgado.Text = dgvAdelantos.CurrentRow.Cells[3].Value.ToString();
            txtImportePagado.Text = dgvAdelantos.CurrentRow.Cells[4].Value.ToString();
            cmbBeneficio.Text = dgvAdelantos.CurrentRow.Cells[5].Value.ToString();
            txtSaldoAdeudado.Text = dgvAdelantos.CurrentRow.Cells[6].Value.ToString();
            txtBeneficiario.Text = dgvAdelantos.CurrentRow.Cells[7].Value?.ToString();            
        }


        //validación del código

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
          //

            if ((Char.IsLetterOrDigit(e.KeyChar)
                    || e.KeyChar == '\b'))                 
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Regex.IsMatch(txtCodigo.Text, @"^\d+$");

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            try
            {
                var empleadoSeleccionado = this.dgvEmpleados.SelectedRows[0].DataBoundItem as Empleado;
                var adelantoSeleccionado = this.dgvAdelantos.SelectedRows[0].DataBoundItem as Adelanto;

                adelantoSeleccionado.Pago = empleadoSeleccionado;
                this.adelantoBusiness.ActualizarImporte(adelantoSeleccionado);

                MessageBox.Show("Se actualizó el importe pagado");

                CargarDatosAdelantosEmpleados(empleadoSeleccionado.Legajo);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
