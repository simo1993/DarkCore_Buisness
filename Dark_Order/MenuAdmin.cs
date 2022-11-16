using System;
using System.Windows.Forms;

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
            SPRINT_MESSI.AdminCoord adminCoord = new SPRINT_MESSI.AdminCoord();
            adminCoord.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DarkCoreGestionDispositivos.GestionDispositivos gestionDispositivos = new DarkCoreGestionDispositivos.GestionDispositivos();
            gestionDispositivos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sprint3_gestio_dusuaris.GestioUsuari gestioUsuari = new Sprint3_gestio_dusuaris.GestioUsuari();
            gestioUsuari.ShowDialog();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
