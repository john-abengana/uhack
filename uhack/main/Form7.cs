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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form hidform in Application.OpenForms)
            {
                if (hidform is Form4)
                {
                    hidform.Show();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Delete selected message?","Delete",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                lbxUnits.SelectedItem = "";
            } 
        }

        

        
    }
}
