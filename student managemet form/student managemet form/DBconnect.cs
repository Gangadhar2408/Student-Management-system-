using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace student_managemet_form
{
    /*
     * In this class create the connection between application and mysql database
     * we need to install xampp and mysql connector to this project
     * we need to create student database
     */

    class DBconnect
    {
        //to create connection
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=studentdb");

        //to get connection
        public MySqlConnection GetConnection
        {
            get
            {
                return connect;
            }
        }

        //create a function to open connection
        public void openConnect()
        {
            if(connect.State==System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //create a function to close funnection
        public void closeConnect ()
        {
            if(connect.State==System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
