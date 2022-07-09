using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puffer
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("www.google.com");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            if (textBox1.Text.Contains("otc.school.nz"))
            {
                MessageBox.Show("This website could not be loaded correctly. " +
                   "This could be due to the code of the webpage not being supported in this browser.", "Webpage Error",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else 
            {
               
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
