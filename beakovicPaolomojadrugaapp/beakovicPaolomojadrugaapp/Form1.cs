using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beakovicPaolomojadrugaapp
{
    public partial class Form1 : Form
    {
        int broj = 0;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            broj++;
            textPrikaz.Text = broj.ToString();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            broj--;
            textPrikaz.Text = broj.ToString();
        }
    }
}
