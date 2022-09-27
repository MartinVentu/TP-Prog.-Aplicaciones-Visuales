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
            this.lblProductos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.bD3K3G10_2022DataSet = new TPPAV.BD3K3G10_2022DataSet();
            this.lotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lotesTableAdapter = new TPPAV.BD3K3G10_2022DataSetTableAdapters.LotesTableAdapter();
            this.idLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuilProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new TPPAV.BD3K3G10_2022DataSetTableAdapters.ProductosTableAdapter();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new TPPAV.BD3K3G10_2022DataSetTableAdapters.ProveedoresTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pnlLotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G10_2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLotes
            // 
            this.pnlLotes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlLotes.Controls.Add(this.comboBox2);
            this.pnlLotes.Controls.Add(this.lblProveedor);
            this.pnlLotes.Controls.Add(this.comboBox1);
            this.pnlLotes.Controls.Add(this.pnlOpciones);
            this.pnlLotes.Controls.Add(this.dataGridView1);
            this.pnlLotes.Controls.Add(this.lblProductos);
            this.pnlLotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLotes.Location = new System.Drawing.Point(0, 0);
            this.pnlLotes.Name = "pnlLotes";
            this.pnlLotes.Size = new System.Drawing.Size(981, 767);
            this.pnlLotes.TabIndex = 0;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(12, 206);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(64, 16);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(981, 127);
            this.pnlOpciones.TabIndex = 2;
            // 
            // bD3K3G10_2022DataSet
            // 
            this.bD3K3G10_2022DataSet.DataSetName = "BD3K3G10_2022DataSet";
            this.bD3K3G10_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lotesBindingSource
            // 
            this.lotesBindingSource.DataMember = "Lotes";
            this.lotesBindingSource.DataSource = this.bD3K3G10_2022DataSet;
            // 
            // lotesTableAdapter
            // 
            this.lotesTableAdapter.ClearBeforeFill = true;
            // 
            // idLoteDataGridViewTextBoxColumn
            // 
            this.idLoteDataGridViewTextBoxColumn.DataPropertyName = "Id_Lote";
            this.idLoteDataGridViewTextBoxColumn.HeaderText = "Id_Lote";
            this.idLoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLoteDataGridViewTextBoxColumn.Name = "idLoteDataGridViewTextBoxColumn";
            this.idLoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLoteDataGridViewTextBoxColumn.Width = 125;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cuilProveedorDataGridViewTextBoxColumn
            // 
            this.cuilProveedorDataGridViewTextBoxColumn.DataPropertyName = "Cuil_Proveedor";
            this.cuilProveedorDataGridViewTextBoxColumn.HeaderText = "Cuil_Proveedor";
            this.cuilProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cuilProveedorDataGridViewTextBoxColumn.Name = "cuilProveedorDataGridViewTextBoxColumn";
            this.cuilProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuilProveedorDataGridViewTextBoxColumn.Width = 125;
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
            // cantidadActualDataGridViewTextBoxColumn
            // 
            this.cantidadActualDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Actual";
            this.cantidadActualDataGridViewTextBoxColumn.HeaderText = "Cantidad_Actual";
            this.cantidadActualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadActualDataGridViewTextBoxColumn.Name = "cantidadActualDataGridViewTextBoxColumn";
            this.cantidadActualDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadActualDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadInicialDataGridViewTextBoxColumn
            // 
            this.cantidadInicialDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Inicial";
            this.cantidadInicialDataGridViewTextBoxColumn.HeaderText = "Cantidad_Inicial";
            this.cantidadInicialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadInicialDataGridViewTextBoxColumn.Name = "cantidadInicialDataGridViewTextBoxColumn";
            this.cantidadInicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadInicialDataGridViewTextBoxColumn.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productosBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(382, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Id_Producto";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.bD3K3G10_2022DataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(12, 236);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(74, 16);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.proveedoresBindingSource;
            this.comboBox2.DisplayMember = "Apellido";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(92, 233);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(382, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "Apellido";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.bD3K3G10_2022DataSet;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(112, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // frmLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 767);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.pnlLotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLotes";
            this.Text = "frmLotes";
            this.Load += new System.EventHandler(this.frmLotes_Load);
            this.pnlLotes.ResumeLayout(false);
            this.pnlLotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G10_2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Panel pnlOpciones;
        private BD3K3G10_2022DataSet bD3K3G10_2022DataSet;
        private System.Windows.Forms.BindingSource lotesBindingSource;
        private BD3K3G10_2022DataSetTableAdapters.LotesTableAdapter lotesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuilProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private BD3K3G10_2022DataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private BD3K3G10_2022DataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}