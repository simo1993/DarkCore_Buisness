using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Dark_Order_Pellitero_Carles
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {

            Telcas_Panel();
            Usuari_Panel();
            
        }

        private void Usuari_Panel()
        {
            Random random = new Random();

            //Random panel = new Random(); a lo mejor quitar
            string[] lletres = { "A", "B", "C", "D" };
            string[] numeros = { "1", "2", "3", "4", "5" };

            //Numero ajensiat al usuari.
            int LIndex = random.Next(lletres.Length);
            int NIndex = random.Next(numeros.Length);

            usuari.Text = lletres[LIndex] + numeros[NIndex];
        }
        
        private void Telcas_Panel()
        {
            Random random = new Random();
            ArrayList panel = new ArrayList();
            Queue<string> llistat = new Queue<string>();

            for (int i = 0; i < 10; i++)
            {
                panel.Add(i);
            }

            for (int i = 0; i < 10; i++)
            {
                int Indexproba = random.Next(9 - i);
                llistat.Enqueue(panel[Indexproba].ToString());
                panel.RemoveAt(Indexproba);
            }

            //Crear el panel amb les seves tecles 
            for (int i = 0; i < 10; i++)
            {

                Button tecla = new Button();
                tecla.Size = new Size(67, 54);
                tableLayoutPanel.Controls.Add(tecla);
                tecla.Text = llistat.Dequeue();

                tecla.Click += (sender, e) =>
                {
                    pantalla.Text = pantalla.Text + tecla.Text;
                };
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void butBorrar_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length != 0)
            {
                pantalla.Text = pantalla.Text.Substring(0, (pantalla.Text.Length - 1));
            }
        }

        private void Botovalidar_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Equals("4554"))
            {
                this.Hide();
                Form5 administracio = new Form5();
                administracio.admin.Text = usuari.Text;
                administracio.ShowDialog();
                AddOwnedForm(administracio);
                
            }
            else
            {
                MessageBox.Show("Contrasenya incorrecta");
            }
        }
    }
}
