using System;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;


namespace Sprint3_gestio_dusuaris
{
    public partial class GestioUsuari : Form
    {
        public GestioUsuari()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valorNuevo = cbUsers.Text;

            XmlDocument xml = new XmlDocument();
            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xml.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value== "TrustedUser")
                        {
                            node.Attributes[1].Value = valorNuevo;
                        }
                    }
                }
            }

            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");

        }

        private void GestioUsuari_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
