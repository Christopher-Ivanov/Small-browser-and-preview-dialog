using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(textBox1.Text);
            if (!comboBox1.Items.Contains(textBox1.Text))
                comboBox1.Items.Add(textBox1.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoForward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoBack();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();
            tooltip1.SetToolTip(this.button1, "Button GO");
            System.Windows.Forms.ToolTip tooltip2 = new System.Windows.Forms.ToolTip();
            tooltip1.SetToolTip(this.button2, "Button LAST");
            System.Windows.Forms.ToolTip tooltip3 = new System.Windows.Forms.ToolTip();
            tooltip1.SetToolTip(this.button3, "Button FORWARD");

            

            radioButton1.Checked = true;



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            toolTip1.Active = true;
            toolTip2.Active = false;       
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            toolTip1.Active = false;
            toolTip2.Active = true;
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                webBrowser1.Navigate(openFileDialog1.FileName);
            {
               
            
            }
        }

        private void t(object sender, MouseEventArgs e)
        {

        }
    }
}