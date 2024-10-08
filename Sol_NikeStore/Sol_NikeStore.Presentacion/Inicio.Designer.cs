namespace Sol_NikeStore.Presentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuNegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuverDetallesVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuReportesCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuReportesVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBackup = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuMantenedor,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuBackup});
            this.menu.Location = new System.Drawing.Point(0, 70);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1246, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(80, 69);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.AutoSize = false;
            this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCategoria,
            this.subMenuProducto,
            this.subMenuNegocio});
            this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuMantenedor.IconColor = System.Drawing.Color.Black;
            this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenedor.IconSize = 50;
            this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(80, 69);
            this.menuMantenedor.Text = "Mantenedor";
            this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuCategoria
            // 
            this.subMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCategoria.IconColor = System.Drawing.Color.Black;
            this.subMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCategoria.Name = "subMenuCategoria";
            this.subMenuCategoria.Size = new System.Drawing.Size(128, 22);
            this.subMenuCategoria.Text = "Categoria";
            this.subMenuCategoria.Click += new System.EventHandler(this.subMenuCategoria_Click);
            // 
            // subMenuProducto
            // 
            this.subMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProducto.IconColor = System.Drawing.Color.Black;
            this.subMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProducto.Name = "subMenuProducto";
            this.subMenuProducto.Size = new System.Drawing.Size(128, 22);
            this.subMenuProducto.Text = "Productos";
            this.subMenuProducto.Click += new System.EventHandler(this.subMenuProducto_Click);
            // 
            // subMenuNegocio
            // 
            this.subMenuNegocio.Name = "subMenuNegocio";
            this.subMenuNegocio.Size = new System.Drawing.Size(128, 22);
            this.subMenuNegocio.Text = "Negocio";
            this.subMenuNegocio.Click += new System.EventHandler(this.subMenuNegocio_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarVenta,
            this.subMenuverDetallesVenta});
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 50;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(80, 69);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarVenta
            // 
            this.subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            this.subMenuRegistrarVenta.Size = new System.Drawing.Size(129, 22);
            this.subMenuRegistrarVenta.Text = "Registrar";
            this.subMenuRegistrarVenta.Click += new System.EventHandler(this.subMenuRegistrarVenta_Click);
            // 
            // subMenuverDetallesVenta
            // 
            this.subMenuverDetallesVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuverDetallesVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuverDetallesVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuverDetallesVenta.Name = "subMenuverDetallesVenta";
            this.subMenuverDetallesVenta.Size = new System.Drawing.Size(129, 22);
            this.subMenuverDetallesVenta.Text = "Ver Detalle";
            this.subMenuverDetallesVenta.Click += new System.EventHandler(this.subMenuverDetallesVenta_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarCompra,
            this.subMenuVerDetalleCompra});
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 50;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(80, 69);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            this.subMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.subMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            this.subMenuRegistrarCompra.Size = new System.Drawing.Size(129, 22);
            this.subMenuRegistrarCompra.Text = "Registrar";
            this.subMenuRegistrarCompra.Click += new System.EventHandler(this.subMenuRegistrarCompra_Click);
            // 
            // subMenuVerDetalleCompra
            // 
            this.subMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.subMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            this.subMenuVerDetalleCompra.Size = new System.Drawing.Size(129, 22);
            this.subMenuVerDetalleCompra.Text = "Ver Detalle";
            this.subMenuVerDetalleCompra.Click += new System.EventHandler(this.subMenuVerDetalleCompra_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(80, 69);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.AutoSize = false;
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuProveedores.IconColor = System.Drawing.Color.Black;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.IconSize = 50;
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(80, 69);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuReportesCompras,
            this.subMenuReportesVentas});
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(80, 69);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuReportesCompras
            // 
            this.subMenuReportesCompras.Name = "subMenuReportesCompras";
            this.subMenuReportesCompras.Size = new System.Drawing.Size(166, 22);
            this.subMenuReportesCompras.Text = "Reporte Compras";
            this.subMenuReportesCompras.Click += new System.EventHandler(this.subMenuReportesCompras_Click);
            // 
            // subMenuReportesVentas
            // 
            this.subMenuReportesVentas.Name = "subMenuReportesVentas";
            this.subMenuReportesVentas.Size = new System.Drawing.Size(166, 22);
            this.subMenuReportesVentas.Text = "Reporte Ventas";
            this.subMenuReportesVentas.Click += new System.EventHandler(this.subMenuReportesVentas_Click);
            // 
            // menuBackup
            // 
            this.menuBackup.AutoSize = false;
            this.menuBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.menuBackup.IconColor = System.Drawing.Color.Black;
            this.menuBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuBackup.IconSize = 50;
            this.menuBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuBackup.Name = "menuBackup";
            this.menuBackup.Size = new System.Drawing.Size(80, 69);
            this.menuBackup.Text = "Backup";
            this.menuBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuBackup.Click += new System.EventHandler(this.menuBackup_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Indigo;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1246, 70);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 143);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1246, 563);
            this.contenedor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(769, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Indigo;
            this.lblusuario.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(769, 59);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(79, 21);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Indigo;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(1013, 38);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 65);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox2.Location = new System.Drawing.Point(655, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1368, 73);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Sol_NikeStore.Presentacion.Properties.Resources._2;
            this.pictureBox3.Location = new System.Drawing.Point(173, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(309, 52);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Indigo;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRol.Location = new System.Drawing.Point(769, 90);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(74, 21);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "labelRol";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 706);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nike-Store";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem subMenuCategoria;
        private FontAwesome.Sharp.IconMenuItem subMenuProducto;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuverDetallesVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleCompra;
        private System.Windows.Forms.ToolStripMenuItem subMenuNegocio;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconMenuItem menuBackup;
        private System.Windows.Forms.ToolStripMenuItem subMenuReportesCompras;
        private System.Windows.Forms.ToolStripMenuItem subMenuReportesVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblRol;
    }
}

