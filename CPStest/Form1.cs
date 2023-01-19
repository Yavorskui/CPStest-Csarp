using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CPStest
{
    public partial class Form1 : Form
    {
        double s, cpsresult;
        double choosedcase = 3;
        int clicks = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void s3btn_Click(object sender, EventArgs e)
        {
            s = 3;
            choosedcase = 3;
            cliackarea.Text = "Click here\n" + choosedcase + " seconds";
        }
        private void s5btn_Click(object sender, EventArgs e)
        {
            s = 5;
            choosedcase = 5;
            cliackarea.Text = "Click here\n" + choosedcase + " seconds";
        }
        private void s10btn_Click(object sender, EventArgs e)
        {
            s = 10;
            choosedcase = 10;
            cliackarea.Text = "Click here\n" + choosedcase + " seconds";
        }
        private void s30btn_Click(object sender, EventArgs e)
        {
            s = 30;
            choosedcase = 30;
            cliackarea.Text = "Click here\n" + choosedcase + " seconds";
        }

        private void customsecondbtn_Click(object sender, EventArgs e)
        {
            choosedcase = Math.Round(double.Parse(numericUpDown.Value.ToString()), 1);
            cliackarea.Text = "Click here\n" + choosedcase + " seconds";
        }

        private void maintimer_Tick(object sender, EventArgs e)
        {
            s = Math.Round(s - 0.1, 1);
            cliackarea.Text = s.ToString();
            if (s == 0)
            {
                maintimer.Enabled = false;
                s3btn.Enabled = true;
                s5btn.Enabled = true;
                s10btn.Enabled = true;
                s30btn.Enabled = true;
                customsecondbtn.Enabled = true;
                numericUpDown.Enabled = true;
                cpsresult = clicks / choosedcase;
                MessageBox.Show("CPS: " + Math.Round(cpsresult, 2).ToString() + "\nTotal clicks: " + clicks,"Your result");
                cliackarea.Text = choosedcase + " seconds test\nCPS: " + Math.Round(cpsresult, 2);
            }
        }

        private void cliackarea_Click(object sender, EventArgs e)
        {
            if (maintimer.Enabled == false)
            {
                maintimer.Enabled = true;
                clicks = 0;
                s = choosedcase;
                s3btn.Enabled = false;
                s5btn.Enabled = false;
                s10btn.Enabled = false;
                s30btn.Enabled = false;
                customsecondbtn.Enabled = false;
                numericUpDown.Enabled = false;
            }
            clicks = clicks + 1;
            clickcounter.Text = "Clicks: " + clicks.ToString();
        }
    }
}
