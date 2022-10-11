using System.Windows.Forms;

namespace TPPAV
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosCompuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificaciónUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeFacturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosDeVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasDeVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesDeVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarLote = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarLote = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.lotesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.listadosDeProductosToolStripMenuItem,
            this.estadísticasDeProductosToolStripMenuItem,
            this.productosCompuestosToolStripMenuItem,
            this.clasificaciónUsoToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo producto";
            // 
            // listadosDeProductosToolStripMenuItem
            // 
            this.listadosDeProductosToolStripMenuItem.Name = "listadosDeProductosToolStripMenuItem";
            this.listadosDeProductosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listadosDeProductosToolStripMenuItem.Text = "Listados";
            // 
            // estadísticasDeProductosToolStripMenuItem
            // 
            this.estadísticasDeProductosToolStripMenuItem.Name = "estadísticasDeProductosToolStripMenuItem";
            this.estadísticasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.estadísticasDeProductosToolStripMenuItem.Text = "Estadísticas";
            // 
            // productosCompuestosToolStripMenuItem
            // 
            this.productosCompuestosToolStripMenuItem.Name = "productosCompuestosToolStripMenuItem";
            this.productosCompuestosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.productosCompuestosToolStripMenuItem.Text = "Productos Compuestos";
            // 
            // clasificaciónUsoToolStripMenuItem
            // 
            this.clasificaciónUsoToolStripMenuItem.Name = "clasificaciónUsoToolStripMenuItem";
            this.clasificaciónUsoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.clasificaciónUsoToolStripMenuItem.Text = "Clasificación Uso";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProveedorToolStripMenuItem,
            this.listadosDeProveedoresToolStripMenuItem,
            this.estadísticasDeProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo proveedor";
            this.nuevoProveedorToolStripMenuItem.Click += new System.EventHandler(this.nuevoProveedorToolStripMenuItem_Click);
            // 
            // listadosDeProveedoresToolStripMenuItem
            // 
            this.listadosDeProveedoresToolStripMenuItem.Name = "listadosDeProveedoresToolStripMenuItem";
            this.listadosDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listadosDeProveedoresToolStripMenuItem.Text = "Listados";
            // 
            // estadísticasDeProveedoresToolStripMenuItem
            // 
            this.estadísticasDeProveedoresToolStripMenuItem.Name = "estadísticasDeProveedoresToolStripMenuItem";
            this.estadísticasDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.estadísticasDeProveedoresToolStripMenuItem.Text = "Estadísticas";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFacturaToolStripMenuItem,
            this.listadosDeFacturasToolStripMenuItem,
            this.estadísticasDeFacturasToolStripMenuItem,
            this.detallesDeFacturasToolStripMenuItem,
            this.procesoDeFacturaciónToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            this.nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            this.nuevaFacturaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.nuevaFacturaToolStripMenuItem.Text = "Nueva factura";
            // 
            // listadosDeFacturasToolStripMenuItem
            // 
            this.listadosDeFacturasToolStripMenuItem.Name = "listadosDeFacturasToolStripMenuItem";
            this.listadosDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.listadosDeFacturasToolStripMenuItem.Text = "Listados";
            // 
            // estadísticasDeFacturasToolStripMenuItem
            // 
            this.estadísticasDeFacturasToolStripMenuItem.Name = "estadísticasDeFacturasToolStripMenuItem";
            this.estadísticasDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.estadísticasDeFacturasToolStripMenuItem.Text = "Estadísticas";
            // 
            // detallesDeFacturasToolStripMenuItem
            // 
            this.detallesDeFacturasToolStripMenuItem.Name = "detallesDeFacturasToolStripMenuItem";
            this.detallesDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.detallesDeFacturasToolStripMenuItem.Text = "Detalles de facturas";
            // 
            // procesoDeFacturaciónToolStripMenuItem
            // 
            this.procesoDeFacturaciónToolStripMenuItem.Name = "procesoDeFacturaciónToolStripMenuItem";
            this.procesoDeFacturaciónToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.procesoDeFacturaciónToolStripMenuItem.Text = "Proceso de facturación";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVendedorToolStripMenuItem,
            this.listadosDeVendedoresToolStripMenuItem,
            this.estadísticasDeVendedoresToolStripMenuItem,
            this.comisionesDeVendedoresToolStripMenuItem});
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // nuevoVendedorToolStripMenuItem
            // 
            this.nuevoVendedorToolStripMenuItem.Name = "nuevoVendedorToolStripMenuItem";
            this.nuevoVendedorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.nuevoVendedorToolStripMenuItem.Text = "Nuevo vendedor";
            this.nuevoVendedorToolStripMenuItem.Click += new System.EventHandler(this.nuevoVendedorToolStripMenuItem_Click);
            // 
            // listadosDeVendedoresToolStripMenuItem
            // 
            this.listadosDeVendedoresToolStripMenuItem.Name = "listadosDeVendedoresToolStripMenuItem";
            this.listadosDeVendedoresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listadosDeVendedoresToolStripMenuItem.Text = "Listados";
            // 
            // estadísticasDeVendedoresToolStripMenuItem
            // 
            this.estadísticasDeVendedoresToolStripMenuItem.Name = "estadísticasDeVendedoresToolStripMenuItem";
            this.estadísticasDeVendedoresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.estadísticasDeVendedoresToolStripMenuItem.Text = "Estadísticas";
            // 
            // comisionesDeVendedoresToolStripMenuItem
            // 
            this.comisionesDeVendedoresToolStripMenuItem.Name = "comisionesDeVendedoresToolStripMenuItem";
            this.comisionesDeVendedoresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.comisionesDeVendedoresToolStripMenuItem.Text = "Comisiones";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.listadosDeClientesToolStripMenuItem,
            this.estadísticasToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo cliente";
            // 
            // listadosDeClientesToolStripMenuItem
            // 
            this.listadosDeClientesToolStripMenuItem.Name = "listadosDeClientesToolStripMenuItem";
            this.listadosDeClientesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listadosDeClientesToolStripMenuItem.Text = "Listados";
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // lotesToolStripMenuItem
            // 
            this.lotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarLote,
            this.btnAgregarLote});
            this.lotesToolStripMenuItem.Name = "lotesToolStripMenuItem";
            this.lotesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lotesToolStripMenuItem.Text = "Lotes";
            // 
            // btnBuscarLote
            // 
            this.btnBuscarLote.Name = "btnBuscarLote";
            this.btnBuscarLote.Size = new System.Drawing.Size(142, 22);
            this.btnBuscarLote.Text = "Buscar Lote";
            this.btnBuscarLote.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnAgregarLote
            // 
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.Size = new System.Drawing.Size(142, 22);
            this.btnAgregarLote.Text = "Agregar Lote";
            this.btnAgregarLote.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 24);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(686, 366);
            this.pnlMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private ToolStripMenuItem listadosDeProductosToolStripMenuItem;
        private ToolStripMenuItem estadísticasDeProductosToolStripMenuItem;
        private ToolStripMenuItem productosCompuestosToolStripMenuItem;
        private ToolStripMenuItem clasificaciónUsoToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private ToolStripMenuItem listadosDeProveedoresToolStripMenuItem;
        private ToolStripMenuItem estadísticasDeProveedoresToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem nuevaFacturaToolStripMenuItem;
        private ToolStripMenuItem listadosDeFacturasToolStripMenuItem;
        private ToolStripMenuItem estadísticasDeFacturasToolStripMenuItem;
        private ToolStripMenuItem detallesDeFacturasToolStripMenuItem;
        private ToolStripMenuItem procesoDeFacturaciónToolStripMenuItem;
        private ToolStripMenuItem vendedoresToolStripMenuItem;
        private ToolStripMenuItem nuevoVendedorToolStripMenuItem;
        private ToolStripMenuItem listadosDeVendedoresToolStripMenuItem;
        private ToolStripMenuItem estadísticasDeVendedoresToolStripMenuItem;
        private ToolStripMenuItem comisionesDeVendedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private ToolStripMenuItem listadosDeClientesToolStripMenuItem;
        private ToolStripMenuItem estadísticasToolStripMenuItem;
        private ToolStripMenuItem lotesToolStripMenuItem;
        private Panel pnlMenu;
        private ToolStripMenuItem btnBuscarLote;
        private ToolStripMenuItem btnAgregarLote;
        private Button button1;
    }
}