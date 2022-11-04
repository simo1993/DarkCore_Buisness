using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkCore
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        int contador = 0;

        private void button1_Click(object sender, EventArgs e)
        {       
          
                if (textBox1.Text == "Moha" && textBox2.Text == "123456")
                {
                    PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                    pantallaPrincipal.Show();                    

                }
                else
                {
                    contador++;                
                    textBox2.Clear();
                }     

            if (contador==3)
            {
                FileStream fitxer = new FileStream("log_error.log",
                FileMode.Append, FileAccess.Write);
                StreamWriter error= new StreamWriter(fitxer);
                error.WriteLine("Date: " + DateTime.Now + " Usuario: " + textBox1.Text);

                error.Close();

                MessageBox.Show("Usuario incorrecto");
                Application.Exit();
            }      
          
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

        }
    }
}
