using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float result = 0F;
        bool second = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            result = 0;
            second = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (second)
            {
                second = false; 
                lblDisplay.Text = btn.Text;
            } else
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = btn.Text;
                }
                else
                {
                    lblDisplay.Text += btn.Text;
                }
            }
            
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            result = result + Convert.ToSingle(lblDisplay.Text);
            lblDisplay.Text = result.ToString();
            second = true;
        }
    }
}
