using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Dark_Order_Pellitero_Carles
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DataSet dts;
        string cnx;
        string taula = "AdminCoordinates";
        SqlConnection conn;

        private void Form3_Load(object sender, EventArgs e)
        {
            Telcas_Panel();
            Usuari_Panel();
        }

        private void Usuari_Panel()
        {
            Random random = new Random();

            string[] lletres = { "A", "B", "C", "D" };
            string[] numeros = { "1", "2", "3", "4", "5" };

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
            cnx = GenerarCnx();
            conn = new SqlConnection(cnx);

            SqlDataAdapter adapter;

            string query;

            query = "select * from "+ taula + " where Coordinate = '" + usuari.Text + "' and ValueCoord = '" + pantalla.Text + "';";

            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            dts = new DataSet();

            adapter.Fill(dts, taula);

            conn.Close();

            if (dts.Tables[0].Rows.Count == 1)
            {
                this.Hide();
                SPRINT_MESSI_MENU.FrmMenu administracio = new SPRINT_MESSI_MENU.FrmMenu();
                administracio.lbUsuari.Text = usuari.Text;
                administracio.ShowDialog();
                AddOwnedForm(administracio);
            }
            else
            {
                MessageBox.Show("Contrasenya incorrecta");
            }
        }
        public string GenerarCnx()
        {
            string cnx = "";

            ConnectionStringSettings connec =
            ConfigurationManager.ConnectionStrings["Conecció"];

            if (connec != null)
            {
                cnx = connec.ConnectionString;
            }
            conn = new SqlConnection(cnx);

            return cnx;
        }
    }
}
