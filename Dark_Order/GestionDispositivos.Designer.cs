namespace DarkCoreGestionDispositivos
{
    partial class GestionDispositivos
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
            this.txtMac = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.lbmac = new System.Windows.Forms.Label();
            this.lbHostName = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMac
            // 
            this.txtMac.Location = new System.Drawing.Point(260, 98);
            this.txtMac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(209, 22);
            this.txtMac.TabIndex = 0;
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(260, 133);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(209, 22);
            this.txtHostName.TabIndex = 1;
            // 
            // lbmac
            // 
            this.lbmac.AutoSize = true;
            this.lbmac.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmac.Location = new System.Drawing.Point(148, 97);
            this.lbmac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmac.Name = "lbmac";
            this.lbmac.Size = new System.Drawing.Size(40, 21);
            this.lbmac.TabIndex = 2;
            this.lbmac.Text = "Mac";
            // 
            // lbHostName
            // 
            this.lbHostName.AutoSize = true;
            this.lbHostName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHostName.Location = new System.Drawing.Point(148, 132);
            this.lbHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHostName.Name = "lbHostName";
            this.lbHostName.Size = new System.Drawing.Size(92, 21);
            this.lbHostName.TabIndex = 3;
            this.lbHostName.Text = "Host Name";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(314, 204);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(100, 28);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(465, 204);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(100, 28);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // GestionDispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(719, 328);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.lbHostName);
            this.Controls.Add(this.lbmac);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.txtMac);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionDispositivos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionDispositivos_FormClosed);
            this.Load += new System.EventHandler(this.GestionDispositivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Label lbmac;
        private System.Windows.Forms.Label lbHostName;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonDelete;
    }
}