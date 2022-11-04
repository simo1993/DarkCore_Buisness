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

namespace DarkCore
{
    public partial class GestionDespositivos : Form
    {
        public GestionDespositivos()
        {
            InitializeComponent();
        }

        private void GestionDespositivos_Load(object sender, EventArgs e)
        {
            textBoxMac.Enabled = false;
            textBoxHostName.Enabled = false;

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


            textBoxMac.Text = mac;

            textBoxHostName.Text = System.Net.Dns.GetHostName();
        }
    }
}
