
namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProsRegisVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProsRegisCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuSalir.Text = "Salir del sistema";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(180, 22);
            this.mnuManProductos.Text = "Productos";
            this.mnuManProductos.Click += new System.EventHandler(this.mnuManProductos_Click);
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(180, 22);
            this.mnuManCategorias.Text = "Categorías";
            this.mnuManCategorias.Click += new System.EventHandler(this.mnuManCategorias_Click);
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(180, 22);
            this.mnuManProveedores.Text = "Proveedores";
            this.mnuManProveedores.Click += new System.EventHandler(this.mnuManProveedores_Click);
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(180, 22);
            this.mnuManClientes.Text = "Clientes";
            this.mnuManClientes.Click += new System.EventHandler(this.mnuManClientes_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProsRegisVenta,
            this.mnuProsRegisCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProsRegisVenta
            // 
            this.mnuProsRegisVenta.Name = "mnuProsRegisVenta";
            this.mnuProsRegisVenta.Size = new System.Drawing.Size(180, 22);
            this.mnuProsRegisVenta.Text = "Registrar Venta";
            this.mnuProsRegisVenta.Click += new System.EventHandler(this.mnuProsRegisVenta_Click);
            // 
            // mnuProsRegisCompra
            // 
            this.mnuProsRegisCompra.Name = "mnuProsRegisCompra";
            this.mnuProsRegisCompra.Size = new System.Drawing.Size(180, 22);
            this.mnuProsRegisCompra.Text = "Registrar Compra";
            this.mnuProsRegisCompra.Click += new System.EventHandler(this.mnuProsRegisCompra_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepVentas,
            this.mnuRepCompras,
            this.mnuInventario,
            this.mnuRepProveedores,
            this.mnuRepUsuarios,
            this.mnuRepClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuRepVentas
            // 
            this.mnuRepVentas.Name = "mnuRepVentas";
            this.mnuRepVentas.Size = new System.Drawing.Size(200, 22);
            this.mnuRepVentas.Text = "Reporte de ventas";
            // 
            // mnuRepCompras
            // 
            this.mnuRepCompras.Name = "mnuRepCompras";
            this.mnuRepCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuRepCompras.Text = "Reporte de compras";
            // 
            // mnuInventario
            // 
            this.mnuInventario.Name = "mnuInventario";
            this.mnuInventario.Size = new System.Drawing.Size(200, 22);
            this.mnuInventario.Text = "Inventario de productos";
            // 
            // mnuRepProveedores
            // 
            this.mnuRepProveedores.Name = "mnuRepProveedores";
            this.mnuRepProveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuRepProveedores.Text = "Reporte de proveedores";
            // 
            // mnuRepUsuarios
            // 
            this.mnuRepUsuarios.Name = "mnuRepUsuarios";
            this.mnuRepUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuRepUsuarios.Text = "Reporte de usuarios";
            // 
            // mnuRepClientes
            // 
            this.mnuRepClientes.Name = "mnuRepClientes";
            this.mnuRepClientes.Size = new System.Drawing.Size(200, 22);
            this.mnuRepClientes.Text = "Reporte de clientes";
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProsRegisVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProsRegisCompra;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRepVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuInventario;
        private System.Windows.Forms.ToolStripMenuItem mnuRepProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRepUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepClientes;
    }
}