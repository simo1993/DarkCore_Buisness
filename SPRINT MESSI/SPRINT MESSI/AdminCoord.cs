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
using System.Data.SqlClient;
using System.Xml;

using System.Threading;

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
            //for (int i = 0; i < code.Count; i++)
            //{
            //    Label lblcolumna = new Label();
            //    lblcolumna.Text = code[i].ToString();
            //    tableLayoutPanel1.Controls.Add(lblcolumna);
            //}

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
                //string codigo = lstcodigo[i];
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
            query = "DELETE FROM [DarkCore].[dbo].[AdminCoordinates]";
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

            XmlDocument xml = new XmlDocument();
            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xml.DocumentElement)
            {
                if (element.Name.Equals("connectionStrings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        cnx = node.Attributes[1].Value.ToString();
                    }
                }
            }

            return cnx;
        }
        private void showData()
        {

            for (int i = 0; i < openWith.Count; i++)
            {
                Label lblcontenido = new Label();
                lblcontenido.Text = openWith[code[i].ToString()];
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

    }
}
