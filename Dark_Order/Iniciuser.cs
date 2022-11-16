using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Dark_Order_Pellitero_Carles
{
    public partial class Form2 : Form
    {
        int count = 0;
        string usuario = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (password.Text.Equals(""))
            {
                MessageBox.Show("Falta contrasenya");
            }
          
            else if (usuari.Text.Equals("Carles Pellitero") && password.Text.Equals("12345aA"))
            {

                MessageBox.Show("Valid");
            }
            else
            {
                MessageBox.Show("Contrasenya incorrecta");

                if (count == 0)
                {
                    usuario = usuari.Text;
                    count++;
                }
                else if (usuari.Text.Equals(usuario) && count > 0)
                {
                    count++;
                }
                else if (!usuari.Text.Equals(usuario))
                {
                    usuario = usuari.Text;
                    count = 1;
                }

                if (count == 3)
                {
                    string path = @"D:\2022.2023\M13\studio\arxius\log_error.log";
                    //Generar fitxer
                    StreamWriter sw = File.AppendText(path);
                    if (File.Exists(path))
                    {
                        sw.WriteLine(DateTime.Now.ToString("yyyy/MM/dd:HH-mm-s") + ":" + usuario);
                        sw.Close();
                    }

                    count = 0;
                    this.Hide();
                    Form6 form6 = new Form6();
                    form6.Show();

                }

            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }
    }
}
