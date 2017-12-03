using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GGboi
{
    public partial class Form6 : Form
    {
        dbConnection db = new dbConnection();
        int unit,mNum,tpnum,amountdue;
        string bdate;
        string name,sex,email, paymentStat, paymentCycle, accountNum;

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        public Form6()
        {
            InitializeComponent();
            cbxCycle.SelectedIndex = 0;
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
                amountdue = (12000 * 12);
            }
            else if (cbxCycle.SelectedItem.Equals("Quarterly"))
            {
                valDue.Text = "" + (12000 * 3)+ ", Every 3 Months" ;
                amountdue = (12000 * 3);
            }
            else if (cbxCycle.SelectedItem.Equals("Monthly"))
            {
                valDue.Text = "" + (12000 * 1) + ", Every Month";
                amountdue = (12000 * 1);
            }

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            unit = Convert.ToInt32(tbxUnit.Text);
            name = tbxName.Text.ToString();
            sex = cbxGender.SelectedItem.ToString();
            bdate = dtpBday.Value.ToShortDateString();
            email = tbxEmail.Text;
            accountNum =tbxact1.Text + tbxact2.Text + tbxact3.Text + tbxact4.Text;
            mNum = Convert.ToInt32(tbxMobile.Text);
            tpnum= Convert.ToInt32(tbxTelephone.Text);
            paymentCycle = cbxCycle.SelectedItem.ToString();
            string sql = "Insert Into customerregistration (CusUnit,FullName,Sex,Bday,BankAccNum)values('" + unit+"','"+name+"','"+sex+"','"+bdate+"','"+ accountNum + "');";
            db.inputData(sql, db.getConnection());
            MessageBox.Show("asdasd");
            sql = "Insert Into contact values('" + mNum + "','" + tpnum + "','" + email + "','" + unit + "');";
            db.inputData(sql, db.getConnection());
            
            sql = "Insert Into customerbilling values('" + amountdue + "','Unpaid','" + paymentCycle + "','" + unit + "');";
            db.inputData(sql, db.getConnection());
           
        }
    }
}
