namespace TPPAV.Pantalla
{
    partial class frmLotes
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
            this.pnlLotes = new System.Windows.Forms.Panel();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.pnlBuscador = new System.Windows.Forms.Panel();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G10_2022DataSet = new TPPAV.BD3K3G10_2022DataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lotesTableAdapter = new TPPAV.BD3K3G10_2022DataSetTableAdapters.LotesTableAdapter();
            this.productosTableAdapter = new TPPAV.BD3K3G10_2022DataSetTableAdapters.ProductosTableAdapter();
            this.proveedoresTableAdapter = new TPPAV.BD3K3G10_2022DataSetTableAdapters.ProveedoresTableAdapter();
            this.idLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuilProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLotes.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            this.pnlBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G10_2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLotes
            // 
            this.pnlLotes.AutoSize = true;
            this.pnlLotes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlLotes.Controls.Add(this.pnlTabla);
            this.pnlLotes.Controls.Add(this.pnlBuscador);
            this.pnlLotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLotes.Location = new System.Drawing.Point(0, 0);
            this.pnlLotes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLotes.Name = "pnlLotes";
            this.pnlLotes.Size = new System.Drawing.Size(736, 623);
            this.pnlLotes.TabIndex = 0;
            // 
            // pnlTabla
            // 
            this.pnlTabla.AutoSize = true;
            this.pnlTabla.Controls.Add(this.dataGridView1);
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Location = new System.Drawing.Point(0, 76);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(736, 547);
            this.pnlTabla.TabIndex = 7;
            // 
            // pnlBuscador
            // 
            this.pnlBuscador.Controls.Add(this.lblProductos);
            this.pnlBuscador.Controls.Add(this.comboBox1);
            this.pnlBuscador.Controls.Add(this.comboBox2);
            this.pnlBuscador.Controls.Add(this.lblProveedor);
            this.pnlBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscador.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscador.Name = "pnlBuscador";
            this.pnlBuscador.Size = new System.Drawing.Size(736, 76);
            this.pnlBuscador.TabIndex = 6;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(11, 9);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(53, 13);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLoteDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cuilProveedorDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.cantidadActualDataGridViewTextBoxColumn,
            this.cantidadInicialDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lotesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 547);
            this.dataGridView1.TabIndex = 1;
            // 
            // lotesBindingSource
            // 
            this.lotesBindingSource.DataMember = "Lotes";
            this.lotesBindingSource.DataSource = this.bD3K3G10_2022DataSet;
            // 
            // bD3K3G10_2022DataSet
            // 
            this.bD3K3G10_2022DataSet.DataSetName = "BD3K3G10_2022DataSet";
            this.bD3K3G10_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productosBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 42);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Id_Producto";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.bD3K3G10_2022DataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.proveedoresBindingSource;
            this.comboBox2.DisplayMember = "Apellido";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(68, 6);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(288, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "Apellido";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.bD3K3G10_2022DataSet;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(11, 42);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lotesTableAdapter
            // 
            this.lotesTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // idLoteDataGridViewTextBoxColumn
            // 
            this.idLoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idLoteDataGridViewTextBoxColumn.DataPropertyName = "Id_Lote";
            this.idLoteDataGridViewTextBoxColumn.HeaderText = "Id_Lote";
            this.idLoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLoteDataGridViewTextBoxColumn.Name = "idLoteDataGridViewTextBoxColumn";
            this.idLoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuilProveedorDataGridViewTextBoxColumn
            // 
            this.cuilProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cuilProveedorDataGridViewTextBoxColumn.DataPropertyName = "Cuil_Proveedor";
            this.cuilProveedorDataGridViewTextBoxColumn.HeaderText = "Cuil_Proveedor";
            this.cuilProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cuilProveedorDataGridViewTextBoxColumn.Name = "cuilProveedorDataGridViewTextBoxColumn";
            this.cuilProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Ingreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha_Ingreso";
            this.fechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            this.fechaIngresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadActualDataGridViewTextBoxColumn
            // 
            this.cantidadActualDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadActualDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Actual";
            this.cantidadActualDataGridViewTextBoxColumn.HeaderText = "Cantidad_Actual";
            this.cantidadActualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadActualDataGridViewTextBoxColumn.Name = "cantidadActualDataGridViewTextBoxColumn";
            this.cantidadActualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadInicialDataGridViewTextBoxColumn
            // 
            this.cantidadInicialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadInicialDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Inicial";
            this.cantidadInicialDataGridViewTextBoxColumn.HeaderText = "Cantidad_Inicial";
            this.cantidadInicialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadInicialDataGridViewTextBoxColumn.Name = "cantidadInicialDataGridViewTextBoxColumn";
            this.cantidadInicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(736, 623);
            this.Controls.Add(this.pnlLotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLotes";
            this.Text = "frmLotes";
            this.Load += new System.EventHandler(this.frmLotes_Load);
            this.pnlLotes.ResumeLayout(false);
            this.pnlLotes.PerformLayout();
            this.pnlTabla.ResumeLayout(false);
            this.pnlBuscador.ResumeLayout(false);
            this.pnlBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G10_2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblProductos;
        private BD3K3G10_2022DataSet bD3K3G10_2022DataSet;
        private System.Windows.Forms.BindingSource lotesBindingSource;
        private BD3K3G10_2022DataSetTableAdapters.LotesTableAdapter lotesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private BD3K3G10_2022DataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private BD3K3G10_2022DataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.Panel pnlBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuilProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadInicialDataGridViewTextBoxColumn;
    }
}