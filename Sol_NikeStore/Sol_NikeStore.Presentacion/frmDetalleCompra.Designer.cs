namespace Sol_NikeStore.Presentacion
{
    partial class frmDetalleCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxInfCompra = new System.Windows.Forms.GroupBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.LTipoDoc = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.groupBoxInfProv = new System.Windows.Forms.GroupBox();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtDocProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDescargarPdf = new FontAwesome.Sharp.IconButton();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInfCompra.SuspendLayout();
            this.groupBoxInfProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(142, 23);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(930, 502);
            this.label11.TabIndex = 24;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Detalle Compra";
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscador.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 16;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(949, 55);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(84, 23);
            this.btnLimpiarBuscador.TabIndex = 32;
            this.btnLimpiarBuscador.Text = "Limpiar";
            this.btnLimpiarBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(855, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 23);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(690, 58);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(159, 20);
            this.txtBusqueda.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(579, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Numero Documento:";
            // 
            // groupBoxInfCompra
            // 
            this.groupBoxInfCompra.BackColor = System.Drawing.Color.White;
            this.groupBoxInfCompra.Controls.Add(this.txtTipoDocumento);
            this.groupBoxInfCompra.Controls.Add(this.txtUsuario);
            this.groupBoxInfCompra.Controls.Add(this.label2);
            this.groupBoxInfCompra.Controls.Add(this.txtFecha);
            this.groupBoxInfCompra.Controls.Add(this.LTipoDoc);
            this.groupBoxInfCompra.Controls.Add(this.LFecha);
            this.groupBoxInfCompra.Location = new System.Drawing.Point(157, 84);
            this.groupBoxInfCompra.Name = "groupBoxInfCompra";
            this.groupBoxInfCompra.Size = new System.Drawing.Size(877, 84);
            this.groupBoxInfCompra.TabIndex = 33;
            this.groupBoxInfCompra.TabStop = false;
            this.groupBoxInfCompra.Text = "Información Compra";
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.txtTipoDocumento.Location = new System.Drawing.Point(311, 44);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(198, 20);
            this.txtTipoDocumento.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuario.Location = new System.Drawing.Point(532, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.Location = new System.Drawing.Point(175, 43);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(113, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(308, 27);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(89, 13);
            this.LTipoDoc.TabIndex = 1;
            this.LTipoDoc.Text = "Tipo Documento:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(172, 27);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 0;
            this.LFecha.Text = "Fecha:";
            // 
            // groupBoxInfProv
            // 
            this.groupBoxInfProv.BackColor = System.Drawing.Color.White;
            this.groupBoxInfProv.Controls.Add(this.txtnumerodocumento);
            this.groupBoxInfProv.Controls.Add(this.txtNombreProveedor);
            this.groupBoxInfProv.Controls.Add(this.txtDocProveedor);
            this.groupBoxInfProv.Controls.Add(this.label3);
            this.groupBoxInfProv.Controls.Add(this.label4);
            this.groupBoxInfProv.Location = new System.Drawing.Point(157, 174);
            this.groupBoxInfProv.Name = "groupBoxInfProv";
            this.groupBoxInfProv.Size = new System.Drawing.Size(877, 84);
            this.groupBoxInfProv.TabIndex = 34;
            this.groupBoxInfProv.TabStop = false;
            this.groupBoxInfProv.Text = "Información Proveedor";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(653, 22);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(31, 20);
            this.txtnumerodocumento.TabIndex = 30;
            this.txtnumerodocumento.Visible = false;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreProveedor.Location = new System.Drawing.Point(375, 47);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(309, 20);
            this.txtNombreProveedor.TabIndex = 29;
            // 
            // txtDocProveedor
            // 
            this.txtDocProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtDocProveedor.Location = new System.Drawing.Point(185, 46);
            this.txtDocProveedor.Name = "txtDocProveedor";
            this.txtDocProveedor.Size = new System.Drawing.Size(130, 20);
            this.txtDocProveedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Razón Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número de Documento:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.Subtotal});
            this.dgvData.Location = new System.Drawing.Point(157, 264);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(877, 209);
            this.dgvData.TabIndex = 35;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(234, 495);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(122, 20);
            this.txtTotalPagar.TabIndex = 38;
            this.txtTotalPagar.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(154, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Total a Pagar:";
            // 
            // btnDescargarPdf
            // 
            this.btnDescargarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnDescargarPdf.IconColor = System.Drawing.Color.SteelBlue;
            this.btnDescargarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarPdf.IconSize = 16;
            this.btnDescargarPdf.Location = new System.Drawing.Point(898, 492);
            this.btnDescargarPdf.Name = "btnDescargarPdf";
            this.btnDescargarPdf.Size = new System.Drawing.Size(136, 22);
            this.btnDescargarPdf.TabIndex = 39;
            this.btnDescargarPdf.Text = "Descargar PDF";
            this.btnDescargarPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarPdf.UseVisualStyleBackColor = true;
            this.btnDescargarPdf.Click += new System.EventHandler(this.btnDescargarPdf_Click);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 540;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
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
            this.Subtotal.Width = 170;
            // 
            // frmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 557);
            this.Controls.Add(this.btnDescargarPdf);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBoxInfProv);
            this.Controls.Add(this.groupBoxInfCompra);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "frmDetalleCompra";
            this.Text = "frmDetalleCompra";
            this.groupBoxInfCompra.ResumeLayout(false);
            this.groupBoxInfCompra.PerformLayout();
            this.groupBoxInfProv.ResumeLayout(false);
            this.groupBoxInfProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxInfCompra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label LTipoDoc;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.GroupBox groupBoxInfProv;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtDocProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnDescargarPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}