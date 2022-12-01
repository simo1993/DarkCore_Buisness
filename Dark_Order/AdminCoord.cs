using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

namespace SPRINT_MESSI
{
    public partial class AdminCoord : Form
    {
        public AdminCoord()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        private string query;
        DataSet dts;
        public Dictionary<string, string> openWith;
        public ArrayList code;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            ArrayList letras = new ArrayList();
            letras.Add("A");
            letras.Add("B");
            letras.Add("C");
            letras.Add("D");

            List<string> lstcodigo = new List<string>();
            HashSet<int> codenum = new HashSet<int>();
            code = new ArrayList();

            int index1 = random.Next(letras.Count);

            for (int i = 0; i < letras.Count; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    code.Add(letras[i] + j.ToString());
                }
            }

            Random rng = new Random();

            while (codenum.Count != code.Count)
            {
                int num = rng.Next(0, 9999);
                codenum.Add(num);
            }
            foreach (var item in codenum)
            {
                string newitem = item.ToString().PadLeft(4, '0');
                lstcodigo.Add(newitem);
            }

            openWith = new Dictionary<string, string>();



            for (int i = 0; i < code.Count; i++)
            {
                string codigo = lstcodigo[i];
                openWith.Add(code[i].ToString(), codigo);
            }

            for (int i = 0; i < openWith.Count; i++)
            {
                
            }

            
            string cnx;
            cnx = GenerarCnx();
            conn = new SqlConnection(cnx);
            SqlDataAdapter sqadapter;
            dts = new DataSet();
            Deletecmd();
            query = "SELECT * FROM ADMINCOORDINATES where 1=2";
            sqadapter = new SqlDataAdapter(query, conn);
            conn.Open();

            sqadapter.Fill(dts, "ADMINCOORDINATES");

            conn.Close();

            DataTable table = dts.Tables[0];
            for (int i = 0; i < openWith.Count; i++)
            {            
                DataRow row = table.NewRow();
                row["Coordinate"] = code[i].ToString();
                row["ValueCoord"] = openWith[code[i].ToString()].ToString();
                dts.Tables[0].Rows.Add(row);

            }
            SaveChanges(); 
        }
        public void Deletecmd()
        {
            query = "DELETE FROM AdminCoordinates";
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            int registresAfectats = cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void SaveChanges()
        {
            SqlDataAdapter adapter;
            conn.Open();
            adapter = new SqlDataAdapter(query, conn);

            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {

                int result = adapter.Update(dts.Tables[0]);

            }
            conn.Close();
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

        private void showData()
        {

            dts = PortarDTS();

            for (int i = 0; i < dts.Tables[0].Rows.Count; i++)
            {
                Label lblcontenido = new Label();
                lblcontenido.Text = dts.Tables[0].Rows[i].Field<string>("ValueCoord");
                lblcontenido.Dock = DockStyle.Fill;
                lblcontenido.TextAlign = ContentAlignment.MiddleCenter;
                tblCoords.Controls.Add(lblcontenido);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tblCoords.Visible = false;

            Control l = this.tblCoords.GetControlFromPosition(1, 1);
            if (l != null)
            {

                for (int i = 1; i <= 20; i++)
                {

                    Control c = this.tblCoords.GetControlFromPosition(1, 1);


                    c.Dispose();

                }
            }
            showData();
            tblCoords.Visible = true;
        }

        public DataSet PortarDTS()
        {
            string cnx;
            cnx = GenerarCnx();
            conn = new SqlConnection(cnx);
            SqlDataAdapter sqadapter;
            dts = new DataSet();

            query = "SELECT * FROM ADMINCOORDINATES";
            sqadapter = new SqlDataAdapter(query, conn);
            conn.Open();

            sqadapter.Fill(dts, "ADMINCOORDINATES");

            conn.Close();

            return dts;
        }

        private void AdminCoord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
