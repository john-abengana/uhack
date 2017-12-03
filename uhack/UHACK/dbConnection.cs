using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GGboi
{
    class dbConnection
    {
        MySqlConnection connection = null;

        public MySqlConnection getConnection()
        {
            try
            {
                string conn = "datasource=localhost;port=3306;database=mydb;username=root;password=password;";
                connection = new MySqlConnection(conn);
                /*MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand();*/
                connection.Open();
                Console.WriteLine("Connected BRUH");
            }
            catch (Exception sophia)
            {
                Console.WriteLine(sophia.Message);
            }

            return connection;
        }

        public void closeConnection()
        {
            connection.Close();
        }

        public void inputData(String query, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public void paid(String query, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public int getData(String query, MySqlConnection connection)
        {
            int sam = 0;
            
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sam = reader.GetInt32("memberID");
            }
            //int resu = Convert.ToInt32(result);
            return sam;
        }
        public int check(String query, MySqlConnection connection)
        {
            int checks = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checks = reader.GetInt32("count(*)");   
            }
            return checks;


        }
        public int unit(String query, MySqlConnection connection)
        {
            int checks = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checks = reader.GetInt32("CustomerRegistration_CusUnit");
            }
            return checks;


        }
        public int subsid(String query, MySqlConnection connection)
        {
            int sam = 0;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sam = reader.GetInt32("subscriptions_subscriptionId");
            }
            //int resu = Convert.ToInt32(result);
            return sam;
        }
        public string report(String query, MySqlConnection connection)
        {
            string checks = "" ;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
              MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checks = reader.GetString("report");
            }
            return checks;


        }
        public string code(String query, MySqlConnection connection)
        {
            try
            {

                string checks = "";
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    checks = reader.GetString("payment");
                }
                return checks;
            }
            catch (Exception)
            {
                return  "sad";
            }

        }
        public int credits(String query, MySqlConnection connection)
        {
            int checks=0 ;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checks = reader.GetInt32("credits");
            }
            return checks;


        }
        public void delete(String query, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public string fname(String query, MySqlConnection connection)
        {
            string checks = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checks = reader.GetString("Fname");
            }
            return checks;


        }
        public string exp(String query, MySqlConnection connection)
        {
            string expire= "";
            int month=0, day=0, year=0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                month = reader.GetInt32("monthExp");
                day = reader.GetInt32("dayExp");
                year = reader.GetInt32("yearExp");
            }



            expire = ""+month+" /"+day+" /"+year ;


            return expire;


        }
    }
}