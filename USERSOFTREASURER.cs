using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Treasurer_App
{
    class USERSOFTREASURER
    {
        my_Database db = new my_Database();

        public bool insertPerson(string fname, string lname, string email, string username, MemoryStream image)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `usersdb`.`users_of_treasurer` (`firstname`, `lastname`, `email`, `username`, `picture`) VALUES (@fn, @ln, @em, @usn, @img); ", db.getConnection());

            //@fn, @ln, @em, @usn, @img
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = image.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() != 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }


        public bool updatePerson(int ID ,string fname, string lname, string email, string username, MemoryStream image)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `usersdb`.`users_of_treasurer` SET `firstname` = @fn,`lastname` = @ln, `email` = @em, `username` = @usn,`picture`= @img WHERE `users_of_treasurer`.`user_id` = @ID; ", db.getConnection());

            //@fn, @ln, @em, @usn, @img
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = image.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() != 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public DataTable getPerson(MySqlCommand command)
        {
            command.Connection = db.getConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);



            return table;

        }

        public bool deletePerson(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `usersdb`.`users_of_treasurer` WHERE (`user_id` = @ID);", db.getConnection());

            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() != 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }


        /*
        public bool getFirstname(MySqlCommand command)
        {
            MySqlCommand command1 = new MySqlCommand("SELECT `firstname` FROM `usersdb`.`users_of_treasurer`;", db.getConnection());


            return true;

        }
        */
    }
}
