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
        XmlDocument xml = new XmlDocument();

        private void btnRegistre_Click(object sender, EventArgs e)
        {
            string valorNou = cbUsers.Text;
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings["TrustedUser"] != null)
            {
                settings["TrustedUser"].Value = valorNou;
            }

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
        //es verificarà si a la secció appSettings de fitxer de configuració hi ha aquest
        //usuari com a valor de la clau TrustedUser
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string Usuari = cbUsers.Text;
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings["TrustedUser"] != null)
            {
                if (settings["TrustedUser"].Value == Usuari)
                {
                    btnDelete.Enabled = true;
                    btnRegistre.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnRegistre.Enabled = true;
                }
            }
        }
        //L'usuari es el que hi consta, d’esborrar-lo del fitxer de configuració.
        private void btnDelete_Click(object sender, EventArgs e)
        {

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings["TrustedUser"] != null)
            {
                settings["TrustedUser"].Value = "";
            }

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        private void GestioUsuari_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
