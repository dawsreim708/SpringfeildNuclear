using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpringfeildNuclear
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Reactor Unstable";
            bool asdf = true;
            while (asdf == true)
            {
                Button1.BackColor = Color.Red;
                Button2.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(50);
                Button1.BackColor = Color.White;
                Button2.BackColor = Color.White;
                Refresh();
                Thread.Sleep(50);
            }

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
           
            asdf = false;
            Button1.BackColor = Color.Green;
            Button2.BackColor = Color.Green;
            label1.Text = "Reactor Stable";
        }
    }
}
