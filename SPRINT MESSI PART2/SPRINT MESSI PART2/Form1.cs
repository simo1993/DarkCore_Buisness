using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace SPRINT_MESSI_PART2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        private string query;
        DataSet dts;
        public string mac = "";
        public string hostname = System.Net.Dns.GetHostName();
        private void GestionDispositivos_Load()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                    }
                }
            }
        }
        private void PortarDD(string cnx)
        {
            conn = new SqlConnection(cnx);
            Boolean users = false;
            Boolean trusted = false;
            SqlDataAdapter sqadapter;
            dts = new DataSet();

            query = "SELECT codeUser,password FROM Users WHERE codeUser = '"+txtUser.Text+"' AND password = '"+txtPswd.Text+"'";
            sqadapter = new SqlDataAdapter(query, conn);
            conn.Open();

            sqadapter.Fill(dts, "Users");
            conn.Close();
            if (dts.Tables[0].Rows.Count == 1)
            {
                users = true;
            }

            if (users)
            {
                conn = new SqlConnection(cnx);
                dts = new DataSet();
                query = "SELECT MAC,HostName FROM TrustedDevices WHERE MAC = '" + mac + "' AND HostName = '" + hostname + "'";
                sqadapter = new SqlDataAdapter(query, conn);
                conn.Open();

                sqadapter.Fill(dts, "TrustedDevices");
                conn.Close();
                if (dts.Tables[0].Rows.Count == 1)
                {
                    trusted = true;
                }
            }

            if (trusted)
            {
                MessageBox.Show("Login Success");
            }


        }
        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                e.Cancel = true;
                txtUser.Focus();
                errorProvider1.SetError(txtUser, "Introduzca Usuario");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUser, null);
            }
        }

        private void txtPswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPswd.Text))
            {
                e.Cancel = true;
                txtPswd.Focus();
                errorProvider1.SetError(txtUser, "Introduzca Contraseña");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUser, null);
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string cnx;
            cnx = GenerarCnx();
            PortarDD(cnx);
            //obtener base de datos
            //verificar usuario
            //verificar contraseña

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPswd.Focus();
                AcceptButton = btnCheck;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GestionDispositivos_Load();
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
    }
}
