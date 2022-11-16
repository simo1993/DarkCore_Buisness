
namespace SPRINT_MESSI_MENU
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnFrm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTxt1 = new System.Windows.Forms.Label();
            this.lblTxt2 = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsuari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrm
            // 
            this.btnFrm.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrm.Location = new System.Drawing.Point(914, 315);
            this.btnFrm.Name = "btnFrm";
            this.btnFrm.Size = new System.Drawing.Size(285, 169);
            this.btnFrm.TabIndex = 0;
            this.btnFrm.Text = "Admin Coordinates";
            this.btnFrm.UseVisualStyleBackColor = true;
            this.btnFrm.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1406, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 169);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gestio de Dispositivos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(914, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 169);
            this.button3.TabIndex = 2;
            this.button3.Text = "Gestio de usuarios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTxt1
            // 
            this.lblTxt1.AutoSize = true;
            this.lblTxt1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt1.Location = new System.Drawing.Point(244, 315);
            this.lblTxt1.Name = "lblTxt1";
            this.lblTxt1.Size = new System.Drawing.Size(360, 55);
            this.lblTxt1.TabIndex = 3;
            this.lblTxt1.Text = "Sith Dark Council";
            // 
            // lblTxt2
            // 
            this.lblTxt2.AutoSize = true;
            this.lblTxt2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt2.Location = new System.Drawing.Point(244, 431);
            this.lblTxt2.Name = "lblTxt2";
            this.lblTxt2.Size = new System.Drawing.Size(328, 38);
            this.lblTxt2.TabIndex = 4;
            this.lblTxt2.Text = "FIRST ORDER SECURITY ";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(905, 174);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(339, 49);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu de opciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsuari
            // 
            this.lbUsuari.AutoSize = true;
            this.lbUsuari.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuari.Location = new System.Drawing.Point(38, 921);
            this.lbUsuari.Name = "lbUsuari";
            this.lbUsuari.Size = new System.Drawing.Size(55, 21);
            this.lbUsuari.TabIndex = 7;
            this.lbUsuari.Text = "usuari";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1703, 972);
            this.Controls.Add(this.lbUsuari);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTxt2);
            this.Controls.Add(this.lblTxt1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFrm);
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu administració";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTxt1;
        private System.Windows.Forms.Label lblTxt2;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbUsuari;
    }
}

