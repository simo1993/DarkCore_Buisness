using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkCore
{
    public partial class PanelAdministrador : Form
    {
        public PanelAdministrador()
        {
            InitializeComponent();
        }


        private void PanelAdministrador_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            string[] Letras = { "A", "B", "C", "D" };
            string[] Numeros_1_5 = { "1", "2", "3", "4", "5" };
            Random letrasAleatoros = new Random();
            string rndLetra = Letras[letrasAleatoros.Next(Letras.Length)];
            Random NumerosAleatorios = new Random();
            string rndNumero= Numeros_1_5[NumerosAleatorios.Next(Numeros_1_5.Length)];

            ArrayList numeros = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                numeros.Add(i);
            }

            Random numAleatorio = new Random();
            Queue<int> cola = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                int num = numAleatorio.Next(9 - i);
                int numero = (int)numeros[num];
                cola.Enqueue(numero);
                numeros.RemoveAt(num);
            }
            int contador = 0;

            do
            {
                Button boton = new Button();
                boton.Width = 118;
                boton.Height = 92;

                boton.Font = new Font("Microsoft Sans Serif", 20f);


                boton.Font = new Font("Microsoft Sans Serif", 13.8f);
                boton.Click += new System.EventHandler(this.NumerosTeclat_Click);

                contador++;

                int valor = cola.Dequeue();

                boton.Text = valor.ToString();
                tableLayoutPanel1.Controls.Add(boton);
                label1.Text = rndLetra;
                label2.Text = rndNumero;

            } while (cola.Count>0);         
        }
        private void NumerosTeclat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;
            textBox1.Text += num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123")
            {
                this.Hide();
                adminScreen form = new adminScreen();
                form.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void PanelAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
