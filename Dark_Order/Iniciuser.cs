using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Net.NetworkInformation;

namespace Dark_Order_Pellitero_Carles
{
    public partial class Form2 : Form
    {
        int count = 0;
        string usuario = "";

        public Form2()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        private string query;
        DataSet dts;
        public string mac = "";
        public string hostname = System.Net.Dns.GetHostName();
        SqlDataAdapter sqadapter;

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
            bool users = false;
            bool trusted = false;
            bool valid = false;
            dts = new DataSet();

            query = "SELECT codeUser,password FROM Users WHERE codeUser = '" + usuari.Text + "' AND password = '" + password.Text + "'";
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
                trusted = ValidarMac(trusted);
            }

            if (trusted)
            {
                valid = ValidarUserAppConfig(valid);
            }

            if (valid)
            {
                MessageBox.Show("VALIDAT, app en process");
            }
            else
            {
                IncorrectaUserOrPass();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cnx;
            cnx = GenerarCnx();
            PortarDD(cnx);
            //obtener base de datos
            //verificar usuario
            //verificar contraseña
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            GestionDispositivos_Load();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
                AcceptButton = btValida;
            }
        }

        private void usuari_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(usuari.Text))
            {
                e.Cancel = true;
                usuari.Focus();
                UsuarioError.SetError(usuari, "Introduzca Usuario");
            }
            else
            {
                e.Cancel = false;
                UsuarioError.SetError(usuari, null);
            }
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text))
            {
                e.Cancel = true;
                password.Focus();
                UsuarioError.SetError(usuari, "Introduzca Contraseña");
            }
            else
            {
                e.Cancel = false;
                UsuarioError.SetError(usuari, null);
            }
        }

        public void IncorrectaUserOrPass()
        {
            MessageBox.Show("Contrasenya incorrecta");

            if (count == 0)
            {
                usuario = usuari.Text;
                count++;
            }
            else if (usuari.Text.Equals(usuario) && count > 0)
            {
                count++;
            }
            else if (!usuari.Text.Equals(usuario))
            {
                usuario = usuari.Text;
                count = 1;
            }

            if (count == 3)
            {
                string path = @"D:\2022.2023\M13\studio\arxius\log_error.log";
                //Generar fitxer
                StreamWriter sw = File.AppendText(path);
                if (File.Exists(path))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy/MM/dd:HH-mm-s") + ":" + usuario);
                    sw.Close();
                }

                count = 0;
                this.Hide();
                Form6 form6 = new Form6();
                form6.Show();

            }
        }

        //Validació User  en el arxiu App.config
        public bool ValidarUserAppConfig(bool valid)
        {
            string Usuari = usuari.Text;
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings["TrustedUser"] != null)
            {
                if (settings["TrustedUser"].Value == Usuari)
                {
                    valid = true;
                }
            }

            return valid;
        }

        //Validació Mac ordinador en la base de dades
        public bool ValidarMac(bool trusted)
        {
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

            return trusted;
        }
    }
}
