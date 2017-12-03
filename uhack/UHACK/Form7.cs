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
    public partial class Form7 : Form
    {
        int units;
        dbConnection db = new dbConnection();
        string query;
        int check,count=0;
        public Form7()
        {
            InitializeComponent();
            

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from report;";
            cmd.Connection = db.getConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                units=reader.GetInt32("CustomerRegistration_CusUnit");
                // MessageBox.Show("" + units);
                lbxUnits.Items.Add(units);
            }
            reader.Close();












           
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

        private void button1_Click(object sender, EventArgs e)
        {
            string reply = textBox2.Text;
            int units = Convert.ToInt32(textBox1.Text);
            query = "update into customerregistration (adminReply) values ('"+reply+ "') where CusUnit='"+units+"';";
            string inputData = db.report(query, db.getConnection());
        }

        private void lbxUnits_MouseClick(object sender, MouseEventArgs e)
        {
            string un = lbxUnits.SelectedItem.ToString();
            int uns = Convert.ToInt32(un);
            query = "select * from report where CustomerRegistration_CusUnit='"+uns+"';";
            string report = db.report(query, db.getConnection());
            textBox3.Text = report;
            textBox1.Text = ""+uns;
        }
    }
}
