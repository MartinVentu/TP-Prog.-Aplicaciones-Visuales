namespace TPPAV.Pantalla
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bD3K3G10_2022DataSet = new TPPAV.BD3K3G10_2022DataSet();
            this.vendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendedoresTableAdapter = new TPPAV.BD3K3G10_2022DataSetTableAdapters.VendedoresTableAdapter();
            this.numeroDtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G10_2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 203);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.numeroDtoDataGridViewTextBoxColumn,
            this.tipoDtoDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.comisionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 282);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(962, 185);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // bD3K3G10_2022DataSet
            // 
            this.bD3K3G10_2022DataSet.DataSetName = "BD3K3G10_2022DataSet";
            this.bD3K3G10_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendedoresBindingSource
            // 
            this.vendedoresBindingSource.DataMember = "Vendedores";
            this.vendedoresBindingSource.DataSource = this.bD3K3G10_2022DataSet;
            // 
            // vendedoresTableAdapter
            // 
            this.vendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // numeroDtoDataGridViewTextBoxColumn
            // 
            this.numeroDtoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Dto";
            this.numeroDtoDataGridViewTextBoxColumn.HeaderText = "Numero_Dto";
            this.numeroDtoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDtoDataGridViewTextBoxColumn.Name = "numeroDtoDataGridViewTextBoxColumn";
            this.numeroDtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDtoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDtoDataGridViewTextBoxColumn
            // 
            this.tipoDtoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Dto";
            this.tipoDtoDataGridViewTextBoxColumn.HeaderText = "Tipo_Dto";
            this.tipoDtoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDtoDataGridViewTextBoxColumn.Name = "tipoDtoDataGridViewTextBoxColumn";
            this.tipoDtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDtoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Ingreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha_Ingreso";
            this.fechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            this.fechaIngresoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaIngresoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNacimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // comisionDataGridViewTextBoxColumn
            // 
            this.comisionDataGridViewTextBoxColumn.DataPropertyName = "Comision";
            this.comisionDataGridViewTextBoxColumn.HeaderText = "Comision";
            this.comisionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comisionDataGridViewTextBoxColumn.Name = "comisionDataGridViewTextBoxColumn";
            this.comisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.comisionDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 778);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G10_2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private BD3K3G10_2022DataSet bD3K3G10_2022DataSet;
        private System.Windows.Forms.BindingSource vendedoresBindingSource;
        private BD3K3G10_2022DataSetTableAdapters.VendedoresTableAdapter vendedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionDataGridViewTextBoxColumn;
    }
}