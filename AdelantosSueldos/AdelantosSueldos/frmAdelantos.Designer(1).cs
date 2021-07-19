
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
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarAdelanto = new System.Windows.Forms.Button();
            this.dgvAdelantos = new System.Windows.Forms.DataGridView();
            this.dgvAdelantosEmpleado = new System.Windows.Forms.DataGridView();
            this.btnAsociarAdelantoEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantosEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 65);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(645, 232);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(12, 24);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(122, 23);
            this.btnAgregarEmpleado.TabIndex = 1;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(156, 24);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(114, 23);
            this.btnEliminarEmpleado.TabIndex = 2;
            this.btnEliminarEmpleado.Text = "button1";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAdelanto
            // 
            this.btnAgregarAdelanto.Location = new System.Drawing.Point(12, 332);
            this.btnAgregarAdelanto.Name = "btnAgregarAdelanto";
            this.btnAgregarAdelanto.Size = new System.Drawing.Size(122, 23);
            this.btnAgregarAdelanto.TabIndex = 4;
            this.btnAgregarAdelanto.Text = "Agregar Adelanto";
            this.btnAgregarAdelanto.UseVisualStyleBackColor = true;
            // 
            // dgvAdelantos
            // 
            this.dgvAdelantos.AllowUserToAddRows = false;
            this.dgvAdelantos.AllowUserToDeleteRows = false;
            this.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAdelantos.Location = new System.Drawing.Point(12, 373);
            this.dgvAdelantos.Name = "dgvAdelantos";
            this.dgvAdelantos.ReadOnly = true;
            this.dgvAdelantos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdelantos.Size = new System.Drawing.Size(645, 232);
            this.dgvAdelantos.TabIndex = 3;
            // 
            // dgvAdelantosEmpleado
            // 
            this.dgvAdelantosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantosEmpleado.Location = new System.Drawing.Point(758, 373);
            this.dgvAdelantosEmpleado.Name = "dgvAdelantosEmpleado";
            this.dgvAdelantosEmpleado.Size = new System.Drawing.Size(645, 232);
            this.dgvAdelantosEmpleado.TabIndex = 6;
            this.dgvAdelantosEmpleado.SelectionChanged += new System.EventHandler(this.dgvAdelantosEmpleado_SelectionChanged);
            this.dgvAdelantosEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAdelantosEmpleado_MouseClick);
            // 
            // btnAsociarAdelantoEmpleado
            // 
            this.btnAsociarAdelantoEmpleado.Location = new System.Drawing.Point(758, 331);
            this.btnAsociarAdelantoEmpleado.Name = "btnAsociarAdelantoEmpleado";
            this.btnAsociarAdelantoEmpleado.Size = new System.Drawing.Size(125, 24);
            this.btnAsociarAdelantoEmpleado.TabIndex = 7;
            this.btnAsociarAdelantoEmpleado.Text = "Asociar Adelanto ";
            this.btnAsociarAdelantoEmpleado.UseVisualStyleBackColor = true;
            this.btnAsociarAdelantoEmpleado.Click += new System.EventHandler(this.btnAsociarAdelantoEmpleado_Click);
            // 
            // frmAdelantos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 826);
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
    }
}