using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkCore
{
    public partial class pantallaSplash : Form
    {
        public pantallaSplash()
        {
            InitializeComponent();
        }
        int contador = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            label2.Text = contador.ToString() + "%";
            if (contador == 100)
            {
                timer1.Stop();
                this.Hide();
                FrmLogin main = new FrmLogin();
                main.ShowDialog();
            }


        }

        private void pantallaSplash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && (e.Alt))
            {
                timer1.Stop();
                this.Hide();
                PanelAdministrador panelAdmini = new PanelAdministrador();
                panelAdmini.Show();

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pantallaSplash_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
