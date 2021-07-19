
namespace AdelantosSueldos
{
    partial class frmAdelantos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.ColumnaLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarAdelanto = new System.Windows.Forms.Button();
            this.dgvAdelantos = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaImporteOt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaImportePag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaBeneficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaSaldoAde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdelantosEmpleado = new System.Windows.Forms.DataGridView();
            this.ColumnaCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaOtorgamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCancelacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaOtor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaBen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAsociarAdelantoEmpleado = new System.Windows.Forms.Button();
            this.txt_Legajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Sueldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Benef = new System.Windows.Forms.TextBox();
            this.txt_SaldoAum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Otor = new System.Windows.Forms.TextBox();
            this.txt_Canc = new System.Windows.Forms.TextBox();
            this.txt_ImporO = new System.Windows.Forms.TextBox();
            this.txt_ImportePag = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantosEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaLegajo,
            this.ColumnaNombre,
            this.ColumnaApellido,
            this.ColumnaSueldo,
            this.Categoria});
            this.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpleados.Location = new System.Drawing.Point(121, 65);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(506, 236);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // ColumnaLegajo
            // 
            this.ColumnaLegajo.HeaderText = "Legajo";
            this.ColumnaLegajo.Name = "ColumnaLegajo";
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            // 
            // ColumnaApellido
            // 
            this.ColumnaApellido.HeaderText = "Apellido";
            this.ColumnaApellido.Name = "ColumnaApellido";
            // 
            // ColumnaSueldo
            // 
            this.ColumnaSueldo.HeaderText = "Sueldo";
            this.ColumnaSueldo.Name = "ColumnaSueldo";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(114, 23);
            this.btnAgregarEmpleado.TabIndex = 1;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(168, 12);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(114, 23);
            this.btnEliminarEmpleado.TabIndex = 2;
            this.btnEliminarEmpleado.Text = "Eliminar empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eliminar Adelanto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAgregarAdelanto
            // 
            this.btnAgregarAdelanto.Location = new System.Drawing.Point(666, 36);
            this.btnAgregarAdelanto.Name = "btnAgregarAdelanto";
            this.btnAgregarAdelanto.Size = new System.Drawing.Size(122, 23);
            this.btnAgregarAdelanto.TabIndex = 4;
            this.btnAgregarAdelanto.Text = "Agregar Adelanto";
            this.btnAgregarAdelanto.UseVisualStyleBackColor = true;
            this.btnAgregarAdelanto.Click += new System.EventHandler(this.btnAgregarAdelanto_Click);
            // 
            // dgvAdelantos
            // 
            this.dgvAdelantos.AllowUserToOrderColumns = true;
            this.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodigo,
            this.ColumnaFecha,
            this.ColumnaCancelacion,
            this.ColumnaImporteOt,
            this.ColumnaImportePag,
            this.ColumnaBeneficio,
            this.ColumnaSaldoAde});
            this.dgvAdelantos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAdelantos.Location = new System.Drawing.Point(633, 65);
            this.dgvAdelantos.Name = "dgvAdelantos";
            this.dgvAdelantos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdelantos.Size = new System.Drawing.Size(728, 232);
            this.dgvAdelantos.TabIndex = 3;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.HeaderText = "Codigo";
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            // 
            // ColumnaFecha
            // 
            this.ColumnaFecha.HeaderText = "Fecha de Otorgamiento";
            this.ColumnaFecha.Name = "ColumnaFecha";
            // 
            // ColumnaCancelacion
            // 
            this.ColumnaCancelacion.HeaderText = "Fecha de Cancelación";
            this.ColumnaCancelacion.Name = "ColumnaCancelacion";
            // 
            // ColumnaImporteOt
            // 
            this.ColumnaImporteOt.HeaderText = "Importe Otorgado";
            this.ColumnaImporteOt.Name = "ColumnaImporteOt";
            // 
            // ColumnaImportePag
            // 
            this.ColumnaImportePag.HeaderText = "Importe Pagado";
            this.ColumnaImportePag.Name = "ColumnaImportePag";
            // 
            // ColumnaBeneficio
            // 
            this.ColumnaBeneficio.HeaderText = "Beneficio";
            this.ColumnaBeneficio.Name = "ColumnaBeneficio";
            // 
            // ColumnaSaldoAde
            // 
            this.ColumnaSaldoAde.HeaderText = "Saldo Adeudado";
            this.ColumnaSaldoAde.Name = "ColumnaSaldoAde";
            // 
            // dgvAdelantosEmpleado
            // 
            this.dgvAdelantosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantosEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCod,
            this.ColumnaOtorgamiento,
            this.ColumnaCancelacion1,
            this.ColumnaOtor,
            this.ColumnaPag,
            this.ColumnaBen,
            this.ColumnaSal});
            this.dgvAdelantosEmpleado.Location = new System.Drawing.Point(143, 387);
            this.dgvAdelantosEmpleado.Name = "dgvAdelantosEmpleado";
            this.dgvAdelantosEmpleado.Size = new System.Drawing.Size(744, 232);
            this.dgvAdelantosEmpleado.TabIndex = 6;
            this.dgvAdelantosEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdelantosEmpleado_CellContentClick);
            this.dgvAdelantosEmpleado.SelectionChanged += new System.EventHandler(this.dgvAdelantosEmpleado_SelectionChanged);
            this.dgvAdelantosEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAdelantosEmpleado_MouseClick);
            // 
            // ColumnaCod
            // 
            this.ColumnaCod.HeaderText = "Código";
            this.ColumnaCod.Name = "ColumnaCod";
            // 
            // ColumnaOtorgamiento
            // 
            this.ColumnaOtorgamiento.HeaderText = "Fecha de Otorgamiento";
            this.ColumnaOtorgamiento.Name = "ColumnaOtorgamiento";
            // 
            // ColumnaCancelacion1
            // 
            this.ColumnaCancelacion1.HeaderText = "Fecha de Cancelación";
            this.ColumnaCancelacion1.Name = "ColumnaCancelacion1";
            // 
            // ColumnaOtor
            // 
            this.ColumnaOtor.HeaderText = "Importe Otorgado";
            this.ColumnaOtor.Name = "ColumnaOtor";
            // 
            // ColumnaPag
            // 
            this.ColumnaPag.HeaderText = "Importe Pagado";
            this.ColumnaPag.Name = "ColumnaPag";
            // 
            // ColumnaBen
            // 
            this.ColumnaBen.HeaderText = "Beneficio";
            this.ColumnaBen.Name = "ColumnaBen";
            // 
            // ColumnaSal
            // 
            this.ColumnaSal.HeaderText = "Saldo Adeudado";
            this.ColumnaSal.Name = "ColumnaSal";
            // 
            // btnAsociarAdelantoEmpleado
            // 
            this.btnAsociarAdelantoEmpleado.Location = new System.Drawing.Point(15, 343);
            this.btnAsociarAdelantoEmpleado.Name = "btnAsociarAdelantoEmpleado";
            this.btnAsociarAdelantoEmpleado.Size = new System.Drawing.Size(125, 24);
            this.btnAsociarAdelantoEmpleado.TabIndex = 7;
            this.btnAsociarAdelantoEmpleado.Text = "Asociar Adelanto ";
            this.btnAsociarAdelantoEmpleado.UseVisualStyleBackColor = true;
            this.btnAsociarAdelantoEmpleado.Click += new System.EventHandler(this.btnAsociarAdelantoEmpleado_Click);
            // 
            // txt_Legajo
            // 
            this.txt_Legajo.Location = new System.Drawing.Point(12, 74);
            this.txt_Legajo.Name = "txt_Legajo";
            this.txt_Legajo.Size = new System.Drawing.Size(100, 20);
            this.txt_Legajo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(12, 120);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "apellido";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(12, 176);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 13;
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(15, 222);
            this.txt_Sueldo.Name = "txt_Sueldo";
            this.txt_Sueldo.Size = new System.Drawing.Size(92, 20);
            this.txt_Sueldo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "sueldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "categoria";
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(15, 281);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(100, 20);
            this.txt_Categoria.TabIndex = 17;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(26, 387);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 18;
            this.txt_Codigo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Codigo_Validating);
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(27, 371);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(39, 13);
            this.codigo.TabIndex = 24;
            this.codigo.Text = "codigo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 638);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "saldoaum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 587);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "benef";
            // 
            // txt_Benef
            // 
            this.txt_Benef.Location = new System.Drawing.Point(26, 603);
            this.txt_Benef.Name = "txt_Benef";
            this.txt_Benef.Size = new System.Drawing.Size(100, 20);
            this.txt_Benef.TabIndex = 41;
            // 
            // txt_SaldoAum
            // 
            this.txt_SaldoAum.Location = new System.Drawing.Point(26, 654);
            this.txt_SaldoAum.Name = "txt_SaldoAum";
            this.txt_SaldoAum.Size = new System.Drawing.Size(100, 20);
            this.txt_SaldoAum.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "fechaotor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "fechacanc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "importepag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "importeotor";
            // 
            // txt_Otor
            // 
            this.txt_Otor.Location = new System.Drawing.Point(26, 426);
            this.txt_Otor.Name = "txt_Otor";
            this.txt_Otor.Size = new System.Drawing.Size(100, 20);
            this.txt_Otor.TabIndex = 35;
            // 
            // txt_Canc
            // 
            this.txt_Canc.Location = new System.Drawing.Point(26, 475);
            this.txt_Canc.Name = "txt_Canc";
            this.txt_Canc.Size = new System.Drawing.Size(100, 20);
            this.txt_Canc.TabIndex = 34;
            // 
            // txt_ImporO
            // 
            this.txt_ImporO.Location = new System.Drawing.Point(26, 514);
            this.txt_ImporO.Name = "txt_ImporO";
            this.txt_ImporO.Size = new System.Drawing.Size(100, 20);
            this.txt_ImporO.TabIndex = 33;
            // 
            // txt_ImportePag
            // 
            this.txt_ImportePag.Location = new System.Drawing.Point(26, 555);
            this.txt_ImportePag.Name = "txt_ImportePag";
            this.txt_ImportePag.Size = new System.Drawing.Size(100, 20);
            this.txt_ImportePag.TabIndex = 32;
            // 
            // frmAdelantos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_Benef);
            this.Controls.Add(this.txt_SaldoAum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Otor);
            this.Controls.Add(this.txt_Canc);
            this.Controls.Add(this.txt_ImporO);
            this.Controls.Add(this.txt_ImportePag);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Sueldo);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Legajo);
            this.Controls.Add(this.btnAsociarAdelantoEmpleado);
            this.Controls.Add(this.dgvAdelantosEmpleado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarAdelanto);
            this.Controls.Add(this.dgvAdelantos);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "frmAdelantos";
            this.Text = "frmAdelantos";
            this.Load += new System.EventHandler(this.frmAdelantos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantosEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarAdelanto;
        private System.Windows.Forms.DataGridView dgvAdelantos;
        private System.Windows.Forms.DataGridView dgvAdelantosEmpleado;
        private System.Windows.Forms.Button btnAsociarAdelantoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaImporteOt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaImportePag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBeneficio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaSaldoAde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaOtorgamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCancelacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaOtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaSal;
        private System.Windows.Forms.TextBox txt_Legajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Sueldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Benef;
        private System.Windows.Forms.TextBox txt_SaldoAum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Otor;
        private System.Windows.Forms.TextBox txt_Canc;
        private System.Windows.Forms.TextBox txt_ImporO;
        private System.Windows.Forms.TextBox txt_ImportePag;
    }
}