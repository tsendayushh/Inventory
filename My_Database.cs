using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

// Connecting mysql database to my app 
using MySql.Data.MySqlClient;

namespace Treasurer_App
{
    class my_Database
    {
        //the connection

        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=mysql1CODE;database=usersdb");

        public MySqlConnection Connection { get => connection; set => connection = value; }

        //open connection
        public void openConnection()
        {
            if(Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        //close connection

        public void closeConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }


        //return connection
        public MySqlConnection getConnection()
        {
            return Connection;
        }

    }
}
