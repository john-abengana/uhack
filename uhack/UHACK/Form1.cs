using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GGboi
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxpass.Text.Equals("dd"))
            {
                
                tbxpass.Text = "";
                Form4 Frmmenu = new Form4();
                Frmmenu.Show();
                this.Hide();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void tbxpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbxpass.Text.Equals("dd"))
            {
               tbxpass.Text = "";
               Form4 Frmmenu = new Form4();
               Frmmenu.Show();
               this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnclose_MouseHover(object sender, EventArgs e)
        {
            btnclose.BackColor = Color.FromArgb(255, 250, 41, 41);
            btnclose.ForeColor = Color.White;
            btnclose.FlatAppearance.BorderColor = Color.FromArgb(250, 41, 41);
        }

        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.BackColor = Color.Transparent;
            btnclose.ForeColor = Color.DimGray;
            btnclose.FlatAppearance.BorderColor = Color.DimGray;
        }

        private void tbxpass_Click(object sender, EventArgs e)
        {
            tbxpass.Clear();
        }
    }
}
