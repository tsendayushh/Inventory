using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Treasurer_App
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        //Login click event
        private void button_Login_MouseClick(object sender, MouseEventArgs e)
        {
            my_Database db = new my_Database();

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users_of_treasurer` WHERE `username` = @usn and `password` = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //hiisen user baigaa esehiig shalgaj bn
            if(table.Rows.Count > 0)
            {
                //herew username iin ilerts 0 oos ih bwl oruulsn user exist bn
                //MessageBox.Show("Yes your account is existing bro");
                //end login amjilttai bolsn tul Main_Form iig ajillulna
                this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                MessageBox.Show("No, Your account does't exist or something went wrong duuude");
                
            }
        }

    }
}
