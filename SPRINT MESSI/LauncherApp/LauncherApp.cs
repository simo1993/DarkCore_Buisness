using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace LauncherApp
{
    public partial class LauncherApp : UserControl
    {
        public LauncherApp()
        {
            InitializeComponent();
        }

        public string CLS
        {
            set;
            get;
        }
        public string Descipcio
        {
            set;
            get;
        }
        public enum Formulari
        {
            AdminCoord
        }
        private Formulari _FormControls;
        public Formulari FormControls
        {
            get { return _FormControls; }

            set

            {

                _FormControls = value;

            }
        }

        private void LauncherApp_Click(object sender, EventArgs e)
        {


            Assembly ensamblat =
            Assembly.LoadFrom(@"" + CLS + ".dll");
            Object dllBD;

            Type tipus;
            tipus = ensamblat.GetType(CLS + "." + _FormControls);

            dllBD = Activator.CreateInstance(tipus);
            Form frmAbrir = (Form)dllBD;
            //((Form)dllBD).Show();
            Form frm = this.FindForm();

            foreach (Control item in frm.Controls)
            {
                if (item.Name.Equals("PanelShow"))
                {
                    frmAbrir.TopLevel = false;
                    frmAbrir.FormBorderStyle = FormBorderStyle.None;
                    frmAbrir.Dock = DockStyle.Fill;
                    item.Controls.Add(frmAbrir);
                    item.Tag = frmAbrir;
                    frmAbrir.BringToFront();
                    frmAbrir.Show();

                }
            }
           
        }

        private void LauncherApp_Load(object sender, EventArgs e)
        {
            DescLbl.Text = Descipcio; 
        }
    }
}

