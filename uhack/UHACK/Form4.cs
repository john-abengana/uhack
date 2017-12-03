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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Form5 Frmview = new Form5();
            Frmview.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {




            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                this.Close();
                foreach (Form hidform in Application.OpenForms)
                {
                    if (hidform is Form1)
                    {
                        hidform.Show();
                    }

                }
            }
            
                
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Form6 Frmreg = new Form6();
            Frmreg.Show();
            this.Hide();
        }


        private void btnmessage_Click(object sender, EventArgs e)
        {
            Form7 Frmmes = new Form7();
            Frmmes.Show();
            this.Hide();
        }


    }
}
