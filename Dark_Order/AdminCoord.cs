using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace SPRINT_MESSI
{
    public partial class AdminCoord : Form
    {
        public AdminCoord()
        {
            InitializeComponent();
        }
        public Dictionary<string, string> openWith;
        public ArrayList code;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            tblCoords.Visible = false;
            Random random = new Random();

            ArrayList letras = new ArrayList();
            letras.Add("A");
            letras.Add("B");
            letras.Add("C");
            letras.Add("D");

            List<string> lstcodigo = new List<string>();
            HashSet<int> codenum = new HashSet<int>();
            code = new ArrayList();

            int index1 = random.Next(letras.Count);

            for (int i = 0; i < letras.Count; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    code.Add(letras[i] + j.ToString());
                }
            }

            Random rng = new Random();

            while (codenum.Count != code.Count)
            {
                int num = rng.Next(0, 9999);
                codenum.Add(num);
            }
            foreach (var item in codenum)
            {
                string newitem = item.ToString().PadLeft(4, '0');
                lstcodigo.Add(newitem);
            }

            openWith = new Dictionary<string, string>();

            for (int i = 0; i < code.Count; i++)
            {
                string codigo = lstcodigo[i];
                openWith.Add(code[i].ToString(), codigo);
            }
            tblCoords.Visible = true;
        }

        private void showData()
        {

            for (int i = 0; i < openWith.Count; i++)
            {
                Label lblcontenido = new Label();
                lblcontenido.Text = openWith[code[i].ToString()];
                lblcontenido.Dock = DockStyle.Fill;
                lblcontenido.TextAlign = ContentAlignment.MiddleCenter;
                tblCoords.Controls.Add(lblcontenido);
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tblCoords.Visible = false;

            Control l = this.tblCoords.GetControlFromPosition(1, 1);
            if (l != null)
            {
                for (int i = 1; i <= 20; i++)
                {
                    Control c = this.tblCoords.GetControlFromPosition(1, 1);
                    c.Dispose();
                }
            }

            showData();
            tblCoords.Visible = true;
        }

        private void AdminCoord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
