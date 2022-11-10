
namespace Dark_Order_Pellitero_Carles
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Botovalidar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.Label();
            this.usuari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel.Controls.Add(this.Botovalidar, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.borrar, 0, 3);
            this.tableLayoutPanel.Location = new System.Drawing.Point(33, 79);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.96078F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(223, 238);
            this.tableLayoutPanel.TabIndex = 14;
            // 
            // Botovalidar
            // 
            this.Botovalidar.Location = new System.Drawing.Point(153, 181);
            this.Botovalidar.Name = "Botovalidar";
            this.Botovalidar.Size = new System.Drawing.Size(67, 54);
            this.Botovalidar.TabIndex = 1;
            this.Botovalidar.Text = "#";
            this.Botovalidar.UseVisualStyleBackColor = true;
            this.Botovalidar.Click += new System.EventHandler(this.Botovalidar_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(3, 181);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(69, 54);
            this.borrar.TabIndex = 0;
            this.borrar.Text = "C";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.butBorrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pantalla);
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Controls.Add(this.usuari);
            this.panel1.Controls.Add(this.tableLayoutPanel);
            this.panel1.Location = new System.Drawing.Point(217, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 353);
            this.panel1.TabIndex = 15;
            // 
            // pantalla
            // 
            this.pantalla.Enabled = false;
            this.pantalla.Location = new System.Drawing.Point(94, 323);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(100, 22);
            this.pantalla.TabIndex = 17;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(77, 18);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(136, 17);
            this.titulo.TabIndex = 16;
            this.titulo.Text = "MESSI administració";
            // 
            // usuari
            // 
            this.usuari.AutoSize = true;
            this.usuari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuari.ForeColor = System.Drawing.Color.Red;
            this.usuari.Location = new System.Drawing.Point(126, 49);
            this.usuari.Name = "usuari";
            this.usuari.Size = new System.Drawing.Size(25, 17);
            this.usuari.TabIndex = 15;
            this.usuari.Text = "0X";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administració";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label usuari;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button Botovalidar;
        private System.Windows.Forms.TextBox pantalla;
    }
}