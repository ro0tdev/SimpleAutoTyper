using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAutoTyper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool autoIsOn = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (autoIsOn == false)
            {
                timer1.Interval = Int32.Parse(comboBox1.Text);
                autoIsOn = true;
                timer1.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (autoIsOn == true)
            {
                autoIsOn = false;
                timer1.Enabled = false;
            }
 
        }
    }
}
