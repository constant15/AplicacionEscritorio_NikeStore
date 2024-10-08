namespace Sol_NikeStore.Presentacion
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxInfVenta = new System.Windows.Forms.GroupBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.LTipoDoc = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.groupBoxInfCliente = new System.Windows.Forms.GroupBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.txtDocCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxInfProducto = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.btnCrearVenta = new FontAwesome.Sharp.IconButton();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.IdProductodgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxInfVenta.SuspendLayout();
            this.groupBoxInfCliente.SuspendLayout();
            this.groupBoxInfProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Registar Venta";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(158, 40);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(930, 477);
            this.label11.TabIndex = 25;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxInfVenta
            // 
            this.groupBoxInfVenta.BackColor = System.Drawing.Color.White;
            this.groupBoxInfVenta.Controls.Add(this.cboTipoDocumento);
            this.groupBoxInfVenta.Controls.Add(this.txtFecha);
            this.groupBoxInfVenta.Controls.Add(this.LTipoDoc);
            this.groupBoxInfVenta.Controls.Add(this.LFecha);
            this.groupBoxInfVenta.Location = new System.Drawing.Point(179, 98);
            this.groupBoxInfVenta.Name = "groupBoxInfVenta";
            this.groupBoxInfVenta.Size = new System.Drawing.Size(339, 84);
            this.groupBoxInfVenta.TabIndex = 27;
            this.groupBoxInfVenta.TabStop = false;
            this.groupBoxInfVenta.Text = "Información Venta";
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
            // groupBoxInfCliente
            // 
            this.groupBoxInfCliente.BackColor = System.Drawing.Color.White;
            this.groupBoxInfCliente.Controls.Add(this.txtApellidoCliente);
            this.groupBoxInfCliente.Controls.Add(this.label10);
            this.groupBoxInfCliente.Controls.Add(this.txtIdProveedor);
            this.groupBoxInfCliente.Controls.Add(this.txtNombreCliente);
            this.groupBoxInfCliente.Controls.Add(this.btnBuscarCliente);
            this.groupBoxInfCliente.Controls.Add(this.txtDocCliente);
            this.groupBoxInfCliente.Controls.Add(this.label2);
            this.groupBoxInfCliente.Controls.Add(this.label3);
            this.groupBoxInfCliente.Location = new System.Drawing.Point(524, 98);
            this.groupBoxInfCliente.Name = "groupBoxInfCliente";
            this.groupBoxInfCliente.Size = new System.Drawing.Size(536, 84);
            this.groupBoxInfCliente.TabIndex = 28;
            this.groupBoxInfCliente.TabStop = false;
            this.groupBoxInfCliente.Text = "Información Cliente";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(341, 45);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(167, 20);
            this.txtApellidoCliente.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Apellido:";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(477, 19);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(31, 20);
            this.txtIdProveedor.TabIndex = 30;
            this.txtIdProveedor.Visible = false;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(199, 45);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(136, 20);
            this.txtNombreCliente.TabIndex = 29;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 16;
            this.btnBuscarCliente.Location = new System.Drawing.Point(143, 45);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(45, 20);
            this.btnBuscarCliente.TabIndex = 28;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDocCliente
            // 
            this.txtDocCliente.Location = new System.Drawing.Point(9, 46);
            this.txtDocCliente.Name = "txtDocCliente";
            this.txtDocCliente.Size = new System.Drawing.Size(130, 20);
            this.txtDocCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
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
            this.groupBoxInfProducto.Controls.Add(this.label7);
            this.groupBoxInfProducto.Controls.Add(this.label8);
            this.groupBoxInfProducto.Controls.Add(this.txtIdProducto);
            this.groupBoxInfProducto.Controls.Add(this.txtStock);
            this.groupBoxInfProducto.Controls.Add(this.txtProducto);
            this.groupBoxInfProducto.Controls.Add(this.btnBuscarProducto);
            this.groupBoxInfProducto.Controls.Add(this.txtCodProducto);
            this.groupBoxInfProducto.Controls.Add(this.label4);
            this.groupBoxInfProducto.Controls.Add(this.label6);
            this.groupBoxInfProducto.Controls.Add(this.label5);
            this.groupBoxInfProducto.Location = new System.Drawing.Point(179, 188);
            this.groupBoxInfProducto.Name = "groupBoxInfProducto";
            this.groupBoxInfProducto.Size = new System.Drawing.Size(754, 84);
            this.groupBoxInfProducto.TabIndex = 29;
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
            this.txtPrecioVenta.Location = new System.Drawing.Point(392, 44);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 35;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(121, 20);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(31, 20);
            this.txtIdProducto.TabIndex = 30;
            this.txtIdProducto.Visible = false;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(498, 43);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 34;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(212, 43);
            this.txtProducto.Name = "txtProducto";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Stock:";
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
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.IconSize = 40;
            this.btnAgregarProducto.Location = new System.Drawing.Point(938, 192);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(122, 80);
            this.btnAgregarProducto.TabIndex = 30;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnCrearVenta.IconColor = System.Drawing.Color.SteelBlue;
            this.btnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearVenta.Location = new System.Drawing.Point(939, 432);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(122, 54);
            this.btnCrearVenta.TabIndex = 41;
            this.btnCrearVenta.Text = "Crear Venta";
            this.btnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearVenta.UseVisualStyleBackColor = false;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(938, 317);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(122, 20);
            this.txtTotalPagar.TabIndex = 40;
            this.txtTotalPagar.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(939, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Total a Pagar:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProductodgv,
            this.Producto,
            this.PrecioVenta,
            this.Cantidad,
            this.Subtotal,
            this.btnEliminar});
            this.dgvData.Location = new System.Drawing.Point(179, 278);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(754, 208);
            this.dgvData.TabIndex = 38;
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
            this.Producto.Width = 320;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
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
            // txtPagaCon
            // 
            this.txtPagaCon.Location = new System.Drawing.Point(939, 364);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(122, 20);
            this.txtPagaCon.TabIndex = 43;
            this.txtPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagaCon_KeyDown);
            this.txtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagaCon_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(939, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Paga con:";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(939, 406);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(122, 20);
            this.txtCambio.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(939, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Cambio:";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 557);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPagaCon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.groupBoxInfProducto);
            this.Controls.Add(this.groupBoxInfCliente);
            this.Controls.Add(this.groupBoxInfVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.groupBoxInfVenta.ResumeLayout(false);
            this.groupBoxInfVenta.PerformLayout();
            this.groupBoxInfCliente.ResumeLayout(false);
            this.groupBoxInfCliente.PerformLayout();
            this.groupBoxInfProducto.ResumeLayout(false);
            this.groupBoxInfProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxInfVenta;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label LTipoDoc;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.GroupBox groupBoxInfCliente;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.TextBox txtDocCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxInfProducto;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private FontAwesome.Sharp.IconButton btnCrearVenta;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductodgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}