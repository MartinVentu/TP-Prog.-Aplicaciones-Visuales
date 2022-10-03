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
            this.dtgLote = new System.Windows.Forms.DataGridView();
            this.lotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G10_2022DataSet = new TPPAV.BD3K3G10_2022DataSet();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProducto = new System.Windows.Forms.ComboBox();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlLotes.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            this.pnlBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G10_2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlBotones.SuspendLayout();
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
            this.pnlLotes.Size = new System.Drawing.Size(649, 623);
            this.pnlLotes.TabIndex = 0;
            // 
            // pnlTabla
            // 
            this.pnlTabla.AutoSize = true;
            this.pnlTabla.Controls.Add(this.dtgLote);
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Location = new System.Drawing.Point(0, 203);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(649, 420);
            this.pnlTabla.TabIndex = 7;
            // 
            // pnlBuscador
            // 
            this.pnlBuscador.Controls.Add(this.pnlBotones);
            this.pnlBuscador.Controls.Add(this.dateTimePicker1);
            this.pnlBuscador.Controls.Add(this.lblIngreso);
            this.pnlBuscador.Controls.Add(this.numericUpDown1);
            this.pnlBuscador.Controls.Add(this.lblCantidad);
            this.pnlBuscador.Controls.Add(this.lblProductos);
            this.pnlBuscador.Controls.Add(this.cmbProveedor);
            this.pnlBuscador.Controls.Add(this.cmbProducto);
            this.pnlBuscador.Controls.Add(this.lblProveedor);
            this.pnlBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscador.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscador.Name = "pnlBuscador";
            this.pnlBuscador.Size = new System.Drawing.Size(649, 203);
            this.pnlBuscador.TabIndex = 6;
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(5, 10);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(53, 13);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Producto:";
            // 
            // dtgLote
            // 
            this.dtgLote.AllowUserToAddRows = false;
            this.dtgLote.AllowUserToDeleteRows = false;
            this.dtgLote.AutoGenerateColumns = false;
            this.dtgLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLoteDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cuilProveedorDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.cantidadActualDataGridViewTextBoxColumn,
            this.cantidadInicialDataGridViewTextBoxColumn});
            this.dtgLote.DataSource = this.lotesBindingSource;
            this.dtgLote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLote.Location = new System.Drawing.Point(0, 0);
            this.dtgLote.Margin = new System.Windows.Forms.Padding(2);
            this.dtgLote.Name = "dtgLote";
            this.dtgLote.ReadOnly = true;
            this.dtgLote.RowHeadersWidth = 51;
            this.dtgLote.RowTemplate.Height = 24;
            this.dtgLote.Size = new System.Drawing.Size(649, 420);
            this.dtgLote.TabIndex = 1;
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
            // cmbProveedor
            // 
            this.cmbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProveedor.DataSource = this.productosBindingSource;
            this.cmbProveedor.DisplayMember = "Descripcion";
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(62, 43);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(575, 21);
            this.cmbProveedor.TabIndex = 3;
            this.cmbProveedor.ValueMember = "Id_Producto";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.bD3K3G10_2022DataSet;
            // 
            // cmbProducto
            // 
            this.cmbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProducto.DataSource = this.proveedoresBindingSource;
            this.cmbProducto.DisplayMember = "Apellido";
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(62, 4);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(575, 21);
            this.cmbProducto.TabIndex = 5;
            this.cmbProducto.ValueMember = "Apellido";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.bD3K3G10_2022DataSet;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(5, 43);
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
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(214, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(5, 124);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(59, 26);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad \r\nDisponible:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(62, 122);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(575, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // lblIngreso
            // 
            this.lblIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(5, 71);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(45, 39);
            this.lblIngreso.TabIndex = 10;
            this.lblIngreso.Text = "Fecha \r\nde \r\nIngreso:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(575, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnBuscar);
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 153);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(649, 50);
            this.pnlBotones.TabIndex = 12;
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificar.Location = new System.Drawing.Point(214, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(214, 50);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Location = new System.Drawing.Point(428, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(214, 50);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(649, 623);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G10_2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLotes;
        private System.Windows.Forms.DataGridView dtgLote;
        private System.Windows.Forms.Label lblProductos;
        private BD3K3G10_2022DataSet bD3K3G10_2022DataSet;
        private System.Windows.Forms.BindingSource lotesBindingSource;
        private BD3K3G10_2022DataSetTableAdapters.LotesTableAdapter lotesTableAdapter;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private BD3K3G10_2022DataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.ComboBox cmbProducto;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
    }
}