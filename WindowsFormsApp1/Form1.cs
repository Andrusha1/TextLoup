using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string bfrstring = textBox1.Text;
            string aftstring = bfrstring.ToLower();
            //aftstring = aftstring.Replace('\n', ' '); 
            aftstring = aftstring.Replace(Environment.NewLine, " "); //remove newlines

            if (SymBox.Text.Length >= 1) //Change specific symbol
            {
                string x = SymBox.Text;
                aftstring = aftstring.Replace($"{x}", "♥");
            }
            aftstring = aftstring.Replace('\n', ' ');
            aftstring = aftstring.Replace("♥", "\n♥"); //create new line on hearth symbol
            textBox2.AppendText(aftstring);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string bfrstring = textBox1.Text;
            string aftstring = bfrstring.ToUpper(); 

            aftstring = aftstring.Replace(Environment.NewLine, " "); //remove newlines

            if (SymBox.Text.Length >= 1) //Change specific symbol
            {
                string x = SymBox.Text;
                aftstring = aftstring.Replace($"{x}", "♥");
            }
            aftstring = aftstring.Replace('\n', ' ');
            aftstring = aftstring.Replace("♥", "\n♥"); //create new line on hearth symbol
            textBox2.AppendText(aftstring);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void split_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string splstr = textBox1.Text;

            splstr = splstr.Replace(Environment.NewLine, " "); //remove newlines

            if (SymBox.Text.Length >= 1) //Change specific symbol
            {
                string x = SymBox.Text;
                splstr = splstr.Replace($"{x}", "♥");
            }
            splstr = splstr.Replace("♥", "\n♥"); //create new line on hearth symbol
            if (splstr.Substring(0, 1) == "\n") //remove new line, if first symbol is heart
                splstr = splstr.Substring(1, splstr.Length - 1);
            splstr = splstr.Replace("	", " ");
            textBox2.AppendText(splstr);
        } 
    }
}
