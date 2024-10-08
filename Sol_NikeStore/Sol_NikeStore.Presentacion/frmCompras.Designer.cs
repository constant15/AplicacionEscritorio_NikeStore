namespace Sol_NikeStore.Presentacion
{
    partial class frmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInfCompra = new System.Windows.Forms.GroupBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.LTipoDoc = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.groupBoxInfProv = new System.Windows.Forms.GroupBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.txtDocProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxInfProducto = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.IdProductodgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.groupBoxInfCompra.SuspendLayout();
            this.groupBoxInfProv.SuspendLayout();
            this.groupBoxInfProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(138, 44);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(930, 477);
            this.label11.TabIndex = 23;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Registar Compra";
            // 
            // groupBoxInfCompra
            // 
            this.groupBoxInfCompra.BackColor = System.Drawing.Color.White;
            this.groupBoxInfCompra.Controls.Add(this.cboTipoDocumento);
            this.groupBoxInfCompra.Controls.Add(this.txtFecha);
            this.groupBoxInfCompra.Controls.Add(this.LTipoDoc);
            this.groupBoxInfCompra.Controls.Add(this.LFecha);
            this.groupBoxInfCompra.Location = new System.Drawing.Point(159, 99);
            this.groupBoxInfCompra.Name = "groupBoxInfCompra";
            this.groupBoxInfCompra.Size = new System.Drawing.Size(339, 84);
            this.groupBoxInfCompra.TabIndex = 25;
            this.groupBoxInfCompra.TabStop = false;
            this.groupBoxInfCompra.Text = "Información Compra";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(145, 43);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(188, 21);
            this.cboTipoDocumento.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(9, 43);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(113, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(142, 27);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(89, 13);
            this.LTipoDoc.TabIndex = 1;
            this.LTipoDoc.Text = "Tipo Documento:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(6, 27);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 0;
            this.LFecha.Text = "Fecha:";
            // 
            // groupBoxInfProv
            // 
            this.groupBoxInfProv.BackColor = System.Drawing.Color.White;
            this.groupBoxInfProv.Controls.Add(this.txtIdProveedor);
            this.groupBoxInfProv.Controls.Add(this.txtNombreProveedor);
            this.groupBoxInfProv.Controls.Add(this.btnBuscarProveedor);
            this.groupBoxInfProv.Controls.Add(this.txtDocProveedor);
            this.groupBoxInfProv.Controls.Add(this.label2);
            this.groupBoxInfProv.Controls.Add(this.label3);
            this.groupBoxInfProv.Location = new System.Drawing.Point(504, 99);
            this.groupBoxInfProv.Name = "groupBoxInfProv";
            this.groupBoxInfProv.Size = new System.Drawing.Size(536, 84);
            this.groupBoxInfProv.TabIndex = 26;
            this.groupBoxInfProv.TabStop = false;
            this.groupBoxInfProv.Text = "Información Proveedor";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(477, 19);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(31, 20);
            this.txtIdProveedor.TabIndex = 30;
            this.txtIdProveedor.Visible = false;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(199, 44);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(309, 20);
            this.txtNombreProveedor.TabIndex = 29;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProveedor.IconSize = 16;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(145, 44);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(45, 20);
            this.btnBuscarProveedor.TabIndex = 28;
            this.btnBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtDocProveedor
            // 
            this.txtDocProveedor.Location = new System.Drawing.Point(9, 43);
            this.txtDocProveedor.Name = "txtDocProveedor";
            this.txtDocProveedor.ReadOnly = true;
            this.txtDocProveedor.Size = new System.Drawing.Size(130, 20);
            this.txtDocProveedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razón Social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de Documento:";
            // 
            // groupBoxInfProducto
            // 
            this.groupBoxInfProducto.BackColor = System.Drawing.Color.White;
            this.groupBoxInfProducto.Controls.Add(this.txtCantidad);
            this.groupBoxInfProducto.Controls.Add(this.txtPrecioVenta);
            this.groupBoxInfProducto.Controls.Add(this.txtPrecioCompra);
            this.groupBoxInfProducto.Controls.Add(this.label8);
            this.groupBoxInfProducto.Controls.Add(this.label7);
            this.groupBoxInfProducto.Controls.Add(this.label6);
            this.groupBoxInfProducto.Controls.Add(this.txtIdProducto);
            this.groupBoxInfProducto.Controls.Add(this.txtProducto);
            this.groupBoxInfProducto.Controls.Add(this.btnBuscarProducto);
            this.groupBoxInfProducto.Controls.Add(this.txtCodProducto);
            this.groupBoxInfProducto.Controls.Add(this.label4);
            this.groupBoxInfProducto.Controls.Add(this.label5);
            this.groupBoxInfProducto.Location = new System.Drawing.Point(158, 189);
            this.groupBoxInfProducto.Name = "groupBoxInfProducto";
            this.groupBoxInfProducto.Size = new System.Drawing.Size(754, 84);
            this.groupBoxInfProducto.TabIndex = 27;
            this.groupBoxInfProducto.TabStop = false;
            this.groupBoxInfProducto.Text = "Información de Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(607, 44);
            this.txtCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 20);
            this.txtCantidad.TabIndex = 36;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(501, 43);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 35;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(395, 43);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCompra.TabIndex = 34;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio Venta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Precio Compra:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(121, 20);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(31, 20);
            this.txtIdProducto.TabIndex = 30;
            this.txtIdProducto.Visible = false;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(212, 43);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(177, 20);
            this.txtProducto.TabIndex = 29;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 16;
            this.btnBuscarProducto.Location = new System.Drawing.Point(158, 44);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 20);
            this.btnBuscarProducto.TabIndex = 28;
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(9, 43);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(143, 20);
            this.txtCodProducto.TabIndex = 2;
            this.txtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProducto_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cod. Producto";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProductodgv,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.Subtotal,
            this.btnEliminar});
            this.dgvData.Location = new System.Drawing.Point(158, 279);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(754, 208);
            this.dgvData.TabIndex = 28;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // IdProductodgv
            // 
            this.IdProductodgv.HeaderText = "IdProducto";
            this.IdProductodgv.Name = "IdProductodgv";
            this.IdProductodgv.ReadOnly = true;
            this.IdProductodgv.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 420;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            this.PrecioVenta.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Sub-Total";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 50;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(918, 407);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(122, 20);
            this.txtTotalPagar.TabIndex = 36;
            this.txtTotalPagar.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(938, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Total a Pagar:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnRegistrar.IconColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.Location = new System.Drawing.Point(918, 433);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 54);
            this.btnRegistrar.TabIndex = 37;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.IconSize = 40;
            this.btnAgregarProducto.Location = new System.Drawing.Point(918, 193);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(122, 80);
            this.btnAgregarProducto.TabIndex = 29;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 557);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBoxInfProducto);
            this.Controls.Add(this.groupBoxInfProv);
            this.Controls.Add(this.groupBoxInfCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.groupBoxInfCompra.ResumeLayout(false);
            this.groupBoxInfCompra.PerformLayout();
            this.groupBoxInfProv.ResumeLayout(false);
            this.groupBoxInfProv.PerformLayout();
            this.groupBoxInfProducto.ResumeLayout(false);
            this.groupBoxInfProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInfCompra;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label LTipoDoc;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.GroupBox groupBoxInfProv;
        private System.Windows.Forms.TextBox txtDocProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.GroupBox groupBoxInfProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductodgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}