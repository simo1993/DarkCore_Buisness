﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Order_Pellitero_Carles
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int contador = 0;

        private void expulsar_Tick(object sender, EventArgs e)
        {
            if (contador == 10)
            {

                expulsar.Stop();
                Application.Exit();

            }
            else
            {
                contador++;
            }
        }
    }
}
