using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Spammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUrTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Start Timer
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop Timer
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cBoxIngame.Checked == true)
            {
                // If IngameBox is checked, it opens the ingame chat (Hopefully)
                SendKeys.Send("{t}");
                SendKeys.Send(txtUrTxt.Text);
                SendKeys.Send("{Enter}");
            }
            else 
            { 
                // Send only the text without open the ingame chat
                SendKeys.Send(txtUrTxt.Text);
                SendKeys.Send("{Enter}");
            }
        }

        private void txtIntervall_TextChanged(object sender, EventArgs e)
        {
            // Set Custom Interval as Timer Interval and verify Interval is not negativ.
            int Interval;

            if (int.TryParse(txtIntervall.Text, out Interval))
            {
                if (Interval > 0)
                {
                    timer1.Interval = Interval;
                }
            }
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormsHelpPopUp popup = new FormsHelpPopUp();
            DialogResult dialogresult = popup.ShowDialog();

            if (dialogresult == DialogResult.Cancel)
            {
                popup.Dispose();
            }
        }
    }
}
