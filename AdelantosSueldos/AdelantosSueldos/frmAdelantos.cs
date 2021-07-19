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

        DataTable table = new DataTable();
        int SelectedRow;

        private void frmAdelantos_Load(object sender, EventArgs e)
        {
            /*CargarDatosEmpleados();
            CargarDatosAdelantos();*/
            System.Collections.ArrayList empleados = new System.Collections.ArrayList();
            System.Collections.ArrayList adelantos = new System.Collections.ArrayList();

            /* table.Columns.Add("Legajo", typeof(int));
             table.Columns.Add("Nombre", typeof(string));
             table.Columns.Add("Apellido", typeof(string));
             table.Columns.Add("Sueldo", typeof(decimal));
             table.Columns.Add("Categoría", typeof(string));
            */
            empleados.Add(new Empleado ("1", "Marcos", "Lopez", 150000, 1560));
            empleados.Add(new Empleado("1", "Marcos", "Lopez", 150000, 1560));
            empleados.Add(new Empleado("1", "Marcos", "Lopez", 150000, 1560));
            empleados.Add(new Empleado("1", "Marcos", "Lopez", 150000, 1560));
            empleados.Add(new Empleado("1", "Marcos", "Lopez", 150000, 1560));
            empleados.Add(new Empleado("1", "Marcos", "Lopez", 150000, 1560));
            empleados.Add(new Empleado("1", "Marcos", "Lopez", 150000, 1560));
            /*
            this.dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.AutoGenerateColumns = true;
            this.dgvEmpleados.DataSource = empleados;*/
            /*table.Rows.Add(2, "Micaela", "Lopez", 150000, "Administrativo");
            table.Rows.Add(3, "Agustin", "Lopez", 150000, "Directivo");
            table.Rows.Add(4, "Pablo", "Lopez", 150000, "Operario");
            table.Rows.Add(5, "Jose", "Lopez", 150000, "Operario");
            table.Rows.Add(6, "Martin", "Lopez", 150000, "Administrativo");
            table.Rows.Add(7, "Mauricio", "Lopez", 150000, "Operario");
            table.Rows.Add(8, "Marian", "Lopez", 150000, "Directivo");
            table.Rows.Add(9, "Mayra", "Lopez", 150000, "Directivo");


            dgvEmpleados.DataSource = table;*/
            adelantos.Add(new Adelanto { });

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Add(txt_Legajo.Text, txt_Nombre.Text ,txt_Apellido.Text, txt_Sueldo.Text, txt_Categoria.Text);
            //CargarDatosEmpleados();
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

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.RemoveAt(dgvEmpleados.SelectedRows[0].Index);

        }

        private void dgvAdelantosEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var adelanto = this.dgvAdelantos.Rows[e.RowIndex].DataBoundItem as Adelanto;
            CargarDatosAdelantosEmpleados(adelanto.Codigo);
        }
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            DataGridViewRow row = dgvEmpleados.Rows[SelectedRow];
            txt_Legajo.Text = row.Cells[0].Value.ToString();
            txt_Nombre.Text = row.Cells[1].Value.ToString();
            txt_Apellido.Text = row.Cells[2].Value.ToString();
            txt_Sueldo.Text = row.Cells[3].Value.ToString();
            txt_Categoria.Text = row.Cells[4].Value.ToString();

        }

        private void btnAgregarAdelanto_Click(object sender, EventArgs e)
        {
            dgvAdelantosEmpleado.Rows.Add(txt_Codigo.Text, txt_Otor.Text, txt_Canc.Text, txt_ImporO.Text, txt_ImportePag.Text, txt_Benef, txt_SaldoAum);
            CargarDatosAdelantos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvAdelantosEmpleado.Rows.RemoveAt(dgvEmpleados.SelectedRows[0].Index);

        }

        private void txt_Codigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string cod = txt_Codigo.Text;

                string cod2 = cod.Substring(0, 3);

                string cod3 = cod.Substring(3, 11);

                if (cod2.All(char.IsDigit) && cod3.All(char.IsLetter))
                {                     
                e.Cancel = false;
                }
                else { e.Cancel = true; }
           }
            catch { Console.WriteLine("Verifique que el código tenga los primeros 4 dígitos en número"); }
        }
            
    }
}
