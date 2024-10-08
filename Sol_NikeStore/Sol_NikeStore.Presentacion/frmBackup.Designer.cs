namespace Sol_NikeStore.Presentacion
{
    partial class frmBackup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBackup = new FontAwesome.Sharp.IconButton();
            this.buttonRuta = new FontAwesome.Sharp.IconButton();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 27);
            this.label10.TabIndex = 57;
            this.label10.Text = "Backup";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(655, 557);
            this.label2.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ruta de almacenamiento:";
            // 
            // buttonBackup
            // 
            this.buttonBackup.IconChar = FontAwesome.Sharp.IconChar.Cloud;
            this.buttonBackup.IconColor = System.Drawing.Color.Black;
            this.buttonBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBackup.IconSize = 16;
            this.buttonBackup.Location = new System.Drawing.Point(155, 158);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(170, 29);
            this.buttonBackup.TabIndex = 10;
            this.buttonBackup.Text = "Copia de seguridad";
            this.buttonBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click_1);
            // 
            // buttonRuta
            // 
            this.buttonRuta.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buttonRuta.IconColor = System.Drawing.Color.Black;
            this.buttonRuta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRuta.IconSize = 16;
            this.buttonRuta.Location = new System.Drawing.Point(155, 123);
            this.buttonRuta.Name = "buttonRuta";
            this.buttonRuta.Size = new System.Drawing.Size(170, 29);
            this.buttonRuta.TabIndex = 9;
            this.buttonRuta.Text = "Ruta";
            this.buttonRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRuta.UseVisualStyleBackColor = true;
            this.buttonRuta.Click += new System.EventHandler(this.buttonRuta_Click_1);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(63, 86);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(361, 20);
            this.txtBackup.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonBackup);
            this.groupBox2.Controls.Add(this.buttonRuta);
            this.groupBox2.Controls.Add(this.txtBackup);
            this.groupBox2.Location = new System.Drawing.Point(64, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 237);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Name = "frmBackup";
            this.Text = "frmBackup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton buttonBackup;
        private FontAwesome.Sharp.IconButton buttonRuta;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}