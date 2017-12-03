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
    public partial class Form5 : Form
    {
        dbConnection db = new dbConnection();
        
        string stat, cycle, name, sex, day, acc, mail;
        int reportnum;
        string report;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        int AmountDue = 0, mobile, tele;
        public Form5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string[] arr = new string[2];
            string unit = textBox1.Text;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select a.amountsDue,a.PaymentStat,a.PaymentCylce,b.CusUnit,b.FullName,b.sex,b.Bday,b.BankAccNum,c.mNum,c.Tpnum,c.Email from customerbilling a, customerregistration b ,contact c where b.CusUnit= a.CustomerRegistration_CusUnit and b.CusUnit=c.CustomerRegistration_CusUnit and CusUnit='"+unit+"';";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AmountDue = reader.GetInt32("amountsDue");
                stat = reader.GetString("PaymentStat");
                cycle = reader.GetString("PaymentCylce");
                name = reader.GetString("FullName");
                sex = reader.GetString("sex");
                day = reader.GetString("Bday");
                acc = reader.GetString("BankAccNum");
                mobile = reader.GetInt32("mNum");
                tele = reader.GetInt32("Tpnum");
                mail = reader.GetString("Email");
            }
            reader.Close();
            valUnitNum.Text = unit;
            valName.Text = name;
            valGender.Text = sex;
            valBirth.Text = day;
            valEmail.Text = mail;
            AccNum.Text = acc;
            valMobile.Text = Convert.ToString(mobile);
            valTelNum.Text= Convert.ToString(tele);
            valPayCycle.Text = cycle;
            valAmount.Text = Convert.ToString(AmountDue);
            string query = "SELECT COUNT(*) from report where CustomerRegistration_CusUnit = '"+unit+"';";
            int check1 = db.check(query,db.getConnection ());
            if (check1!=0)
            {
                ListViewItem rep = new ListViewItem();
                
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.CommandText = "SELECT * from report where CustomerRegistration_CusUnit = '"+unit+"';";
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = db.getConnection();
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    reportnum = reader1.GetInt32("reportNumber");
                    report = reader1.GetString("report");
                     
                    arr[0] = ""+reportnum;
                    arr[1] = report;
                     rep = new ListViewItem(arr);
                    reps.Items.Add(rep);
                }
                reader1.Close();
            }



        }
    }
}
