using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace DarkCoreGestionDispositivos
{
    public partial class GestionDispositivos : Form
    {
        public GestionDispositivos()
        {
            InitializeComponent();
        }

        DataSet dts;
        string query;
        private SqlConnection conn;
        private void GestionDispositivos_Load(object sender, EventArgs e)
        {
            txtHostName.Enabled = false;
            txtMac.Enabled = false;

            string mac = "";
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
            txtMac.Text = mac;

            txtHostName.Text = System.Net.Dns.GetHostName();

            Verificació_Mac();

        }
        public DataSet PortarPerConsulta(string querry)
        {
            configurarCion();
            SqlDataAdapter adapter;
            dts = new DataSet();
            adapter = new SqlDataAdapter(querry, conn);
            conn.Open();
            adapter.Fill(dts, "TrustedDevices");
            conn.Close();
            return dts;
        }
        private void configurarCion()
        {
            string cnx = "";

            ConnectionStringSettings connec =
            ConfigurationManager.ConnectionStrings["Conecció"];

            if (connec != null)
            {
                cnx = connec.ConnectionString;
            }
            conn = new SqlConnection(cnx);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            query = "select * from TrustedDevices where MAC = '" + txtMac.Text + "'";
            DataRow dr = dts.Tables[0].NewRow();
            dr["MAC"] = txtMac.Text;
            dr["HostName"] = txtHostName.Text;
            dts.Tables[0].Rows.Add(dr);
            Actualizar(query, dts);
            PortarPerConsulta(query);
            Verificació_Mac();
        }
        public int Actualizar(string querry, DataSet dts)
        {
            configurarCion();
            int result = 0;
            conn.Open();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder cmdbuilder;
            cmdbuilder = new SqlCommandBuilder(adapter);
            if (dts.HasChanges())
            {
                result = adapter.Update(dts.Tables[0]);
            }
            conn.Close();
            return result;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            query = "select * from TrustedDevices where MAC = '" + txtMac.Text + "'";
            dts.Tables[0].Rows[0].Delete();
            Actualizar(query,  dts);
            PortarPerConsulta(query);
            Verificació_Mac();
        }
        private void GestionDispositivos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void Verificació_Mac()
        {
            query = "select * from TrustedDevices where MAC = '" + txtMac.Text + "'";
            dts = PortarPerConsulta(query);
            if (dts.Tables[0].Rows.Count == 0)
            {
                ButtonSave.Enabled = true;
                ButtonDelete.Enabled = false;
            }
            else
            {
                ButtonSave.Enabled = false;
                ButtonDelete.Enabled = true;
            }
        }
    }
}
