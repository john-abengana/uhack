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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            cbxCycle.SelectedIndex=3
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void cbxCycle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCycle.SelectedItem.Equals("Annual")) {
                valDue.Text = "" + (12000 * 12) + ", Once a Year";
            }
            else if (cbxCycle.SelectedItem.Equals("Quarterly"))
            {
                valDue.Text = "" + (12000 * 3)+ ", Every 3 Months" ;
            }
            else if (cbxCycle.SelectedItem.Equals("Monthly"))
            {
                valDue.Text = "" + (12000 * 1) + ", Every Month";
            }

        }

       

       

       

        

       

       

       
    }
}
