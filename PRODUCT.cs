using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Treasurer_App
{
    class PRODUCT
    {
        my_Database db = new my_Database();

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
    }
}
