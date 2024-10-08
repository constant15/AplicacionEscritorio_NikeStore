namespace Sol_NikeStore.Presentacion
{
    partial class frmNegocio
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
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButtonGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombreNegocio = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.lRut = new System.Windows.Forms.Label();
            this.lNombreNegocio = new System.Windows.Forms.Label();
            this.iconButtonSubir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 27);
            this.label10.TabIndex = 52;
            this.label10.Text = "Detalle Negocio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 557);
            this.label1.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.iconButtonGuardarCambios);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.txtNombreNegocio);
            this.groupBox1.Controls.Add(this.lDireccion);
            this.groupBox1.Controls.Add(this.lRut);
            this.groupBox1.Controls.Add(this.lNombreNegocio);
            this.groupBox1.Controls.Add(this.iconButtonSubir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Location = new System.Drawing.Point(43, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 246);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // iconButtonGuardarCambios
            // 
            this.iconButtonGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconButtonGuardarCambios.IconColor = System.Drawing.Color.Black;
            this.iconButtonGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGuardarCambios.IconSize = 16;
            this.iconButtonGuardarCambios.Location = new System.Drawing.Point(237, 188);
            this.iconButtonGuardarCambios.Name = "iconButtonGuardarCambios";
            this.iconButtonGuardarCambios.Size = new System.Drawing.Size(193, 29);
            this.iconButtonGuardarCambios.TabIndex = 9;
            this.iconButtonGuardarCambios.Text = "Guardar Cambios";
            this.iconButtonGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonGuardarCambios.UseVisualStyleBackColor = true;
            this.iconButtonGuardarCambios.Click += new System.EventHandler(this.iconButtonGuardarCambios_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(188, 127);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(298, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(188, 88);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(298, 20);
            this.txtRut.TabIndex = 7;
            // 
            // txtNombreNegocio
            // 
            this.txtNombreNegocio.Location = new System.Drawing.Point(188, 49);
            this.txtNombreNegocio.Name = "txtNombreNegocio";
            this.txtNombreNegocio.Size = new System.Drawing.Size(298, 20);
            this.txtNombreNegocio.TabIndex = 6;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(185, 111);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(55, 13);
            this.lDireccion.TabIndex = 5;
            this.lDireccion.Text = "Dirección:";
            // 
            // lRut
            // 
            this.lRut.AutoSize = true;
            this.lRut.Location = new System.Drawing.Point(185, 72);
            this.lRut.Name = "lRut";
            this.lRut.Size = new System.Drawing.Size(33, 13);
            this.lRut.TabIndex = 4;
            this.lRut.Text = "RUT:";
            // 
            // lNombreNegocio
            // 
            this.lNombreNegocio.AutoSize = true;
            this.lNombreNegocio.Location = new System.Drawing.Point(185, 33);
            this.lNombreNegocio.Name = "lNombreNegocio";
            this.lNombreNegocio.Size = new System.Drawing.Size(87, 13);
            this.lNombreNegocio.TabIndex = 3;
            this.lNombreNegocio.Text = "Nombre Negocio";
            // 
            // iconButtonSubir
            // 
            this.iconButtonSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconButtonSubir.IconColor = System.Drawing.Color.Black;
            this.iconButtonSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSubir.IconSize = 16;
            this.iconButtonSubir.Location = new System.Drawing.Point(20, 188);
            this.iconButtonSubir.Name = "iconButtonSubir";
            this.iconButtonSubir.Size = new System.Drawing.Size(136, 29);
            this.iconButtonSubir.TabIndex = 2;
            this.iconButtonSubir.Text = "Subir";
            this.iconButtonSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSubir.UseVisualStyleBackColor = true;
            this.iconButtonSubir.Click += new System.EventHandler(this.iconButtonSubir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo:";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(20, 44);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(136, 114);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton iconButtonGuardarCambios;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombreNegocio;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Label lRut;
        private System.Windows.Forms.Label lNombreNegocio;
        private FontAwesome.Sharp.IconButton iconButtonSubir;
    }
}