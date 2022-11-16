using System;
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
        }

        private void GestionDispositivos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
