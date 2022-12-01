using System;
using System.Windows.Forms;

namespace Dark_Order_Pellitero_Carles
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temps.Start();
        }

        private void barraprogesiva_Tick(object sender, EventArgs e)
        {
            barraprogresiva.Increment(1);
            if (barraprogresiva.Value == barraprogresiva.Maximum)
            {

                this.Hide();
                temps.Stop();
                Form2 form2 = new Form2();
                form2.Show();

            }
            percent.Text = barraprogresiva.Value.ToString() + "%";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                this.Hide();
                temps.Stop();
                Form3 admin = new Form3(); 
                admin.ShowDialog();
                
            }
        }
    }
}
