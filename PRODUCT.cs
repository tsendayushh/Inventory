using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Treasurer_App
{
    class PRODUCT
    {
        my_Database db = new my_Database();


        //product iig database-d query command iig ashiglan nemeh function
        public bool insertProduct(string pName, string pType, DateTime mDate, DateTime eDate, string owner, MemoryStream image)
        {
            MySqlCommand command = new MySqlCommand(" INSERT INTO `usersdb`.`product`(`pname`,`ptype`,`date_manufactured`,`date_expire`,`person_responsible_for`,`image`) VALUES(@pn,@pt,@dm,@de,@prf,@img);", db.getConnection());

            //@pn, @pt, @dm, @de, @prf, @img
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pName;
            command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = pType;
            command.Parameters.Add("@dm", MySqlDbType.Date).Value = mDate;
            command.Parameters.Add("@de", MySqlDbType.Date).Value = eDate;
            command.Parameters.Add("@prf", MySqlDbType.VarChar).Value = owner;
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

        // product iin data-g table rvv awah function
        public DataTable getProducts( MySqlCommand command)
        {
            command.Connection = db.getConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            

            return table;

        }


        // product iin medeelliig shinechleh function 

        public bool updateProduct(int id, string pName, string pType, DateTime mDate, DateTime eDate, string owner, MemoryStream image)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE `usersdb`.`product` SET `pname` = @pn,`ptype` = @pt,`date_manufactured` = @dm, `date_expire` = @de,`person_responsible_for` = @prf,`image` = @img WHERE `product`.`product_id` = @ID; ", db.getConnection());

                //@pn, @pt, @dm, @de, @prf, @img,@ID
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pName;
                command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = pType;
                command.Parameters.Add("@dm", MySqlDbType.Timestamp).Value = mDate;
                command.Parameters.Add("@de", MySqlDbType.Timestamp).Value = eDate;
                command.Parameters.Add("@prf", MySqlDbType.VarChar).Value = owner;
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
            catch (Exception ex)
            { throw ex; }

        }


        // product iig ustgadag function

        public bool deleteProduct(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `usersdb`.`product` WHERE (`product_id` = @ID);", db.getConnection());

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

    }
}
