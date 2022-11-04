using System;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;


namespace Sprint3_gestio_dusuaris
{
    public partial class Form1 : Form
    {
        public Form1()
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

            //Quan validem l’operació amb el botó Register, el valor escollit en el combobox quedarà gravat en el fitxer
            //app.config a la secció appSettings com a valor de la clau TrustedUser.
            //< add key = "TrustedUser" value = "GutiTheBest" />
        }

        //static void ReadAllSettings()
        //{
        //    try
        //    { 
        //        var appSettings = ConfigurationManager.AppSettings;

        //        if (appSettings.Count == 0)
        //        {
        //            Console.WriteLine("AppSettings is empty.");
        //        }
        //        else
        //        {
        //            foreach (var key in appSettings.AllKeys)
        //            {
        //                Console.WriteLine("Key: {0} Value: {1}", key,appSettings[key]);
        //            }
        //        }
        //    }
        //    catch (ConfigurationErrorsException)
        //    {
        //        Console.WriteLine("Error reading app settings");
        //    }
        //}

        //static void ReadSetting(string key)
        //{
        //    try
        //    {
        //        var appSettings = ConfigurationManager.AppSettings;
        //        string result = appSettings[key] ?? "Not Found";
        //        Console.WriteLine(result);
        //    }
        //    catch (ConfigurationErrorsException)
        //    {
        //        Console.WriteLine("Error reading app settings");
        //    }
        //}

        //static void AddUpdateAppSettings(string key, string value)
        //{
        //    try
        //    {
        //        var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //        var settings = configFile.AppSettings.Settings;
        //        if (settings[key] == null)
        //        {
        //            settings.Add(key, value);
        //        }
        //        else
        //        {
        //            settings[key].Value = value;
        //        }
        //        configFile.Save(ConfigurationSaveMode.Modified);
        //        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        //    }
        //    catch (ConfigurationErrorsException)
        //    {
        //        Console.WriteLine("Error writing app settings");
        //    }
        //}
    }
}
