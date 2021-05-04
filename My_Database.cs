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
    class My_Database
    {
        //the connection
        MySqlConnection connection = new MySqlConnection("datasource-=localhost;port=3306;username=root;password=mysql1CODE;database=usersdb");

        //return connection
        public MySqlConnection getConnection
        {
            get
            {
                return connection;
            }
        }

        //open connection
        public void openConnection()
        {
            if(con.State=ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //close connection

        public void closeConnection()
        {
            if (con.State = ConnectionState.Open)
            {
                con.Close;
            }
        }


    }
}
