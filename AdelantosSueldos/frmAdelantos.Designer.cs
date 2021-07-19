
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
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.dgvAdelantos = new System.Windows.Forms.DataGridView();
            this.dgvAdelantosEmpleado = new System.Windows.Forms.DataGridView();
            this.btnAsociarAdelantoEmpleado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBeneficio = new System.Windows.Forms.ComboBox();
            this.btnEditarAdelanto = new System.Windows.Forms.Button();
            this.dtpFechaCancelacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaOtorgamiento = new System.Windows.Forms.DateTimePicker();
            this.txtBeneficiario = new System.Windows.Forms.TextBox();
            this.txtSaldoAdeudado = new System.Windows.Forms.TextBox();
            this.txtImportePagado = new System.Windows.Forms.TextBox();
            this.txtImporteOtorgado = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblBeneficiario = new System.Windows.Forms.Label();
            this.lblSaldoAdeudado = new System.Windows.Forms.Label();
            this.lblBeneficio = new System.Windows.Forms.Label();
            this.lblImpPag = new System.Windows.Forms.Label();
            this.lblImpOt = new System.Windows.Forms.Label();
            this.lblFechaCanc = new System.Windows.Forms.Label();
            this.lblFechaOt = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregarAdelanto = new System.Windows.Forms.Button();
            this.btnBorrarAdelanto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantosEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpleados.Location = new System.Drawing.Point(281, 19);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(645, 182);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(153, 19);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(114, 23);
            this.btnEliminarEmpleado.TabIndex = 2;
            this.btnEliminarEmpleado.Text = "Eliminar empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // dgvAdelantos
            // 
            this.dgvAdelantos.AllowUserToAddRows = false;
            this.dgvAdelantos.AllowUserToDeleteRows = false;
            this.dgvAdelantos.AllowUserToOrderColumns = true;
            this.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAdelantos.Location = new System.Drawing.Point(324, 19);
            this.dgvAdelantos.Name = "dgvAdelantos";
            this.dgvAdelantos.ReadOnly = true;
            this.dgvAdelantos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdelantos.Size = new System.Drawing.Size(645, 250);
            this.dgvAdelantos.TabIndex = 3;
            this.dgvAdelantos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdelantos_CellContentClick);
            // 
            // dgvAdelantosEmpleado
            // 
            this.dgvAdelantosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantosEmpleado.Location = new System.Drawing.Point(6, 45);
            this.dgvAdelantosEmpleado.Name = "dgvAdelantosEmpleado";
            this.dgvAdelantosEmpleado.Size = new System.Drawing.Size(645, 237);
            this.dgvAdelantosEmpleado.TabIndex = 6;
            this.dgvAdelantosEmpleado.SelectionChanged += new System.EventHandler(this.dgvAdelantosEmpleado_SelectionChanged);
            this.dgvAdelantosEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAdelantosEmpleado_MouseClick);
            // 
            // btnAsociarAdelantoEmpleado
            // 
            this.btnAsociarAdelantoEmpleado.Location = new System.Drawing.Point(6, 15);
            this.btnAsociarAdelantoEmpleado.Name = "btnAsociarAdelantoEmpleado";
            this.btnAsociarAdelantoEmpleado.Size = new System.Drawing.Size(125, 24);
            this.btnAsociarAdelantoEmpleado.TabIndex = 7;
            this.btnAsociarAdelantoEmpleado.Text = "Asociar Adelanto ";
            this.btnAsociarAdelantoEmpleado.UseVisualStyleBackColor = true;
            this.btnAsociarAdelantoEmpleado.Click += new System.EventHandler(this.btnAsociarAdelantoEmpleado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizarEmpleado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.Categoria);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnEliminarEmpleado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvEmpleados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtLegajo);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 253);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(6, 19);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(102, 23);
            this.btnActualizarEmpleado.TabIndex = 26;
            this.btnActualizarEmpleado.Text = "Editar Empleado";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Legajo";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Operario",
            "Administrativo",
            "Directivo"});
            this.cmbCategoria.Location = new System.Drawing.Point(108, 187);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(100, 21);
            this.cmbCategoria.TabIndex = 23;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(3, 195);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(52, 13);
            this.Categoria.TabIndex = 22;
            this.Categoria.Text = "Categoria";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(3, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Agregar Empleado";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sueldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, -29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Legajo";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(108, 161);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(108, 128);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(108, 67);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPago);
            this.groupBox2.Controls.Add(this.cmbBeneficio);
            this.groupBox2.Controls.Add(this.btnEditarAdelanto);
            this.groupBox2.Controls.Add(this.dtpFechaCancelacion);
            this.groupBox2.Controls.Add(this.dtpFechaOtorgamiento);
            this.groupBox2.Controls.Add(this.txtBeneficiario);
            this.groupBox2.Controls.Add(this.txtSaldoAdeudado);
            this.groupBox2.Controls.Add(this.txtImportePagado);
            this.groupBox2.Controls.Add(this.txtImporteOtorgado);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.lblBeneficiario);
            this.groupBox2.Controls.Add(this.lblSaldoAdeudado);
            this.groupBox2.Controls.Add(this.lblBeneficio);
            this.groupBox2.Controls.Add(this.lblImpPag);
            this.groupBox2.Controls.Add(this.lblImpOt);
            this.groupBox2.Controls.Add(this.lblFechaCanc);
            this.groupBox2.Controls.Add(this.lblFechaOt);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.dgvAdelantos);
            this.groupBox2.Controls.Add(this.btnAgregarAdelanto);
            this.groupBox2.Controls.Add(this.btnBorrarAdelanto);
            this.groupBox2.Location = new System.Drawing.Point(20, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 362);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adelantos";
            // 
            // cmbBeneficio
            // 
            this.cmbBeneficio.FormattingEnabled = true;
            this.cmbBeneficio.Items.AddRange(new object[] {
            "Operario",
            "Administrativo",
            "Directivo"});
            this.cmbBeneficio.Location = new System.Drawing.Point(173, 232);
            this.cmbBeneficio.Name = "cmbBeneficio";
            this.cmbBeneficio.Size = new System.Drawing.Size(100, 21);
            this.cmbBeneficio.TabIndex = 24;
            // 
            // btnEditarAdelanto
            // 
            this.btnEditarAdelanto.Location = new System.Drawing.Point(6, 19);
            this.btnEditarAdelanto.Name = "btnEditarAdelanto";
            this.btnEditarAdelanto.Size = new System.Drawing.Size(114, 23);
            this.btnEditarAdelanto.TabIndex = 23;
            this.btnEditarAdelanto.Text = "Editar Adelanto";
            this.btnEditarAdelanto.UseVisualStyleBackColor = true;
            this.btnEditarAdelanto.Click += new System.EventHandler(this.btnEditarAdelanto_Click);
            // 
            // dtpFechaCancelacion
            // 
            this.dtpFechaCancelacion.Enabled = false;
            this.dtpFechaCancelacion.Location = new System.Drawing.Point(173, 134);
            this.dtpFechaCancelacion.Name = "dtpFechaCancelacion";
            this.dtpFechaCancelacion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCancelacion.TabIndex = 22;
            // 
            // dtpFechaOtorgamiento
            // 
            this.dtpFechaOtorgamiento.Location = new System.Drawing.Point(173, 97);
            this.dtpFechaOtorgamiento.Name = "dtpFechaOtorgamiento";
            this.dtpFechaOtorgamiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaOtorgamiento.TabIndex = 21;
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.Location = new System.Drawing.Point(173, 289);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.Size = new System.Drawing.Size(100, 20);
            this.txtBeneficiario.TabIndex = 20;
            // 
            // txtSaldoAdeudado
            // 
            this.txtSaldoAdeudado.Location = new System.Drawing.Point(173, 260);
            this.txtSaldoAdeudado.Name = "txtSaldoAdeudado";
            this.txtSaldoAdeudado.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoAdeudado.TabIndex = 19;
            // 
            // txtImportePagado
            // 
            this.txtImportePagado.Location = new System.Drawing.Point(173, 202);
            this.txtImportePagado.Name = "txtImportePagado";
            this.txtImportePagado.Size = new System.Drawing.Size(100, 20);
            this.txtImportePagado.TabIndex = 17;
            // 
            // txtImporteOtorgado
            // 
            this.txtImporteOtorgado.Location = new System.Drawing.Point(173, 170);
            this.txtImporteOtorgado.Name = "txtImporteOtorgado";
            this.txtImporteOtorgado.Size = new System.Drawing.Size(100, 20);
            this.txtImporteOtorgado.TabIndex = 16;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(173, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // lblBeneficiario
            // 
            this.lblBeneficiario.AutoSize = true;
            this.lblBeneficiario.Location = new System.Drawing.Point(6, 292);
            this.lblBeneficiario.Name = "lblBeneficiario";
            this.lblBeneficiario.Size = new System.Drawing.Size(62, 13);
            this.lblBeneficiario.TabIndex = 12;
            this.lblBeneficiario.Text = "Beneficiario";
            // 
            // lblSaldoAdeudado
            // 
            this.lblSaldoAdeudado.AutoSize = true;
            this.lblSaldoAdeudado.Location = new System.Drawing.Point(6, 263);
            this.lblSaldoAdeudado.Name = "lblSaldoAdeudado";
            this.lblSaldoAdeudado.Size = new System.Drawing.Size(85, 13);
            this.lblSaldoAdeudado.TabIndex = 11;
            this.lblSaldoAdeudado.Text = "Saldo adeudado";
            // 
            // lblBeneficio
            // 
            this.lblBeneficio.AutoSize = true;
            this.lblBeneficio.Location = new System.Drawing.Point(6, 235);
            this.lblBeneficio.Name = "lblBeneficio";
            this.lblBeneficio.Size = new System.Drawing.Size(51, 13);
            this.lblBeneficio.TabIndex = 10;
            this.lblBeneficio.Text = "Beneficio";
            // 
            // lblImpPag
            // 
            this.lblImpPag.AutoSize = true;
            this.lblImpPag.Location = new System.Drawing.Point(6, 205);
            this.lblImpPag.Name = "lblImpPag";
            this.lblImpPag.Size = new System.Drawing.Size(81, 13);
            this.lblImpPag.TabIndex = 9;
            this.lblImpPag.Text = "Importe pagado";
            // 
            // lblImpOt
            // 
            this.lblImpOt.AutoSize = true;
            this.lblImpOt.Location = new System.Drawing.Point(6, 173);
            this.lblImpOt.Name = "lblImpOt";
            this.lblImpOt.Size = new System.Drawing.Size(87, 13);
            this.lblImpOt.TabIndex = 8;
            this.lblImpOt.Text = "Importe otorgado";
            // 
            // lblFechaCanc
            // 
            this.lblFechaCanc.AutoSize = true;
            this.lblFechaCanc.Location = new System.Drawing.Point(6, 140);
            this.lblFechaCanc.Name = "lblFechaCanc";
            this.lblFechaCanc.Size = new System.Drawing.Size(113, 13);
            this.lblFechaCanc.TabIndex = 7;
            this.lblFechaCanc.Text = "Fecha de cancelacion";
            // 
            // lblFechaOt
            // 
            this.lblFechaOt.AutoSize = true;
            this.lblFechaOt.Location = new System.Drawing.Point(6, 104);
            this.lblFechaOt.Name = "lblFechaOt";
            this.lblFechaOt.Size = new System.Drawing.Size(116, 13);
            this.lblFechaOt.TabIndex = 6;
            this.lblFechaOt.Text = "Fecha de otorgamiento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnAgregarAdelanto
            // 
            this.btnAgregarAdelanto.Location = new System.Drawing.Point(6, 332);
            this.btnAgregarAdelanto.Name = "btnAgregarAdelanto";
            this.btnAgregarAdelanto.Size = new System.Drawing.Size(122, 23);
            this.btnAgregarAdelanto.TabIndex = 4;
            this.btnAgregarAdelanto.Text = "Agregar Adelanto";
            this.btnAgregarAdelanto.UseVisualStyleBackColor = true;
            this.btnAgregarAdelanto.Click += new System.EventHandler(this.btnAgregarAdelanto_Click);
            // 
            // btnBorrarAdelanto
            // 
            this.btnBorrarAdelanto.Location = new System.Drawing.Point(173, 332);
            this.btnBorrarAdelanto.Name = "btnBorrarAdelanto";
            this.btnBorrarAdelanto.Size = new System.Drawing.Size(114, 23);
            this.btnBorrarAdelanto.TabIndex = 5;
            this.btnBorrarAdelanto.Text = "Borrar Adelanto";
            this.btnBorrarAdelanto.UseVisualStyleBackColor = true;
            this.btnBorrarAdelanto.Click += new System.EventHandler(this.btnBorrarAdelanto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAdelantosEmpleado);
            this.groupBox3.Controls.Add(this.btnAsociarAdelantoEmpleado);
            this.groupBox3.Location = new System.Drawing.Point(20, 652);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(988, 317);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asociar Adelantos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 555);
            this.panel1.TabIndex = 11;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(168, 19);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(119, 23);
            this.btnPago.TabIndex = 25;
            this.btnPago.Text = "Realizar Pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // frmAdelantos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 559);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdelantos";
            this.Text = "frmAdelantos";
            this.Load += new System.EventHandler(this.frmAdelantos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantosEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.DataGridView dgvAdelantos;
        private System.Windows.Forms.DataGridView dgvAdelantosEmpleado;
        private System.Windows.Forms.Button btnAsociarAdelantoEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblBeneficio;
        private System.Windows.Forms.Label lblImpPag;
        private System.Windows.Forms.Label lblImpOt;
        private System.Windows.Forms.Label lblFechaCanc;
        private System.Windows.Forms.Label lblFechaOt;
        private System.Windows.Forms.Label lblBeneficiario;
        private System.Windows.Forms.Label lblSaldoAdeudado;
        private System.Windows.Forms.TextBox txtBeneficiario;
        private System.Windows.Forms.TextBox txtSaldoAdeudado;
        private System.Windows.Forms.TextBox txtImportePagado;
        private System.Windows.Forms.TextBox txtImporteOtorgado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaOtorgamiento;
        private System.Windows.Forms.Button btnEditarAdelanto;
        private System.Windows.Forms.Button btnAgregarAdelanto;
        private System.Windows.Forms.Button btnBorrarAdelanto;
        private System.Windows.Forms.ComboBox cmbBeneficio;
        private System.Windows.Forms.DateTimePicker dtpFechaCancelacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPago;
    }
}