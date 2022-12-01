using System;
using System.Windows.Forms;
using DarkCoreGestionDispositivos;
using SPRINT_MESSI;
using Sprint3_gestio_dusuaris;

namespace SPRINT_MESSI_MENU
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminCoord adminCoord = new AdminCoord();
            adminCoord.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionDispositivos gestionDispositivos = new GestionDispositivos();
            this.Hide();
            gestionDispositivos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestioUsuari gestioUsuari = new GestioUsuari();
            gestioUsuari.ShowDialog();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
