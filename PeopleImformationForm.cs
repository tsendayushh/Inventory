using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Treasurer_App
{
    public partial class PeopleImformationForm : Form
    {
        public PeopleImformationForm()
        {
            InitializeComponent();
        }

        USERSOFTREASURER usersoftreasurer = new USERSOFTREASURER();

        private void buttonRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            //datagrid iig data aar duurgeh
            MySqlCommand command = new MySqlCommand("SELECT * FROM `usersdb`.`users_of_treasurer`;");

            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.DataSource = usersoftreasurer.getPerson(command);

            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[6];

            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;


            labelSearchResult.Text = "Нийт илэрц: " + dataGridView1.Rows.Count;



        }
        //medeelel bvren esehiig shalgah function
        bool verif()
        {
            if ((textBoxFirstame.Text.Trim() == "") ||
                (textBoxLastname.Text.Trim() == "") ||
                (textBoxEmailaAddress.Text.Trim() == "") ||
                (textBoxUsername.Text.Trim() == "") ||
                (picOfPerson.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonAddPerson_MouseClick(object sender, MouseEventArgs e)
        {
            //medeelel nemeh uildel
    
            string fname = textBoxFirstame.Text;
            string lname = textBoxLastname.Text;
            string email = textBoxEmailaAddress.Text;
            string username = textBoxUsername.Text;

            MemoryStream image = new MemoryStream();



            if (verif())
            {
                labelll.Image.Save(image, labelll.Image.RawFormat);

                if (usersoftreasurer.insertPerson(fname, lname, email, username, image))
                {
                    MessageBox.Show("Хүний мэдээллийн бүртгэл амжилттай боллоо.", "Амжилттай", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("something went wrong dude", "Алдаа гарлаа!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Мэдээлэл дутуу оруулсан байна.\nМэдээллээ шалгаад дахиг оруулна уу!", "Мэдээлэл дутуу байна", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonUpdatePerson_MouseClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(textBoxFindID.Text);
            string fname = textBoxFirstame.Text;
            string lname = textBoxLastname.Text;
            string email = textBoxEmailaAddress.Text;
            string username = textBoxUsername.Text;

            MemoryStream image = new MemoryStream();



            if (verif())
            {
                picOfPerson.Image.Save(image, picOfPerson.Image.RawFormat);

                if (usersoftreasurer.updatePerson(id, fname, lname, email, username, image))
                {
                    MessageBox.Show("Мэдээлэл шинэчлэлт амжилттай боллоо.", "Шинэчлэх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("something went wrong dude", "Шинэчлэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Мэдээлэл дутуу оруулсан байна.\nМэдээллээ шалгаад дахиг оруулна уу!", "Хоосон нүд", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonDeletePerson_MouseClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(textBoxFindID.Text);
            if (MessageBox.Show("Та энэ эд хүний бүртгэлээс устгахдаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usersoftreasurer.deletePerson(id);

                textBoxFindID.Text = "";
                textBoxFirstame.Text = "";
                textBoxLastname.Text = "";
                textBoxEmailaAddress.Text = "";
                textBoxUsername.Text = "";
                picOfPerson.Image = null;

                MessageBox.Show("Эд хогшил бүртгэлээс устгагдлаа.", "Эд хогшил устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Эд хогшил бүртгэлээс устсангүй.", "Эд хогшил устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void buttonOfAddPersonPic_MouseClick(object sender, MouseEventArgs e)
        {
            //com oos zurag awah uildel
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picOfPerson.Image = Image.FromFile(opf.FileName);
            }

        }
        //fill datagrid function
        public void fillDataGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.DataSource = usersoftreasurer.getPerson(command);

            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[6];

            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {
            //oruulsn ugeer haih function

            string query = "SELECT * FROM `usersdb`.`users_of_treasurer`WHERE CONCAT(`firstname`,`lastname`,`email`,`username`) LIKE '%" + textBoxSearch.Text + "%';";
            MySqlCommand command = new MySqlCommand(query);
            fillDataGrid(command);

            labelSearchResult.Text = "Нийт илэрц: " + dataGridView1.Rows.Count;
        }


        private void textBoxFindID_TextChanged(object sender, EventArgs e)
        {
            // id gaar ni person haih uildel

            int id;
            if (textBoxFindID.Text == "") id = 0;
            else
                id = Convert.ToInt32( textBoxFindID.Text.ToString());
            MySqlCommand command = new MySqlCommand("SELECT `firstname`,`lastname`,`email`,`username`,'picture' FROM `usersdb`.`users_of_treasurer` WHERE user_id = " + id);

            DataTable table = usersoftreasurer.getPerson(command);

            if (table.Rows.Count > 0)
            {
                textBoxFirstame.Text = table.Rows[0]["firstname"].ToString();
                textBoxLastname.Text = table.Rows[0]["lastname"].ToString();
                textBoxEmailaAddress.Text = table.Rows[0]["email"].ToString();
                textBoxUsername.Text = table.Rows[0]["username"].ToString();

                /*
                try
                {
                    string s = (string)table.Rows[0]["picture"];
                    byte[] img;
                    img = System.Text.Encoding.ASCII.GetBytes(s);
                    MemoryStream image = new MemoryStream(img);
                    picOfPerson.Image = Image.FromStream(image);

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                */


                /*
                byte[] img;
                img = (byte[])table.Rows[0]["picture"];
                MemoryStream image = new MemoryStream(img);
                picOfPerson.Image = Image.FromStream(image);
                */
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxFindID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstame.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxEmailaAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxUsername.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            byte[] img;
            img = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream image = new MemoryStream(img);
            picOfPerson.Image = Image.FromStream(image);

        }
    }
}
