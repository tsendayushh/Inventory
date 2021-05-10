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
    public partial class AddThingForm : Form
    {
        public AddThingForm()
        {
            InitializeComponent();
        }

        private void buttonOfAddThingsPhoto_MouseClick(object sender, MouseEventArgs e)
        {
            //com oos zurag awah uildel
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxThing.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonCancelAdd_MouseClick(object sender, MouseEventArgs e)
        {
            //tsutslah uildel
            Close();
        }
        // medeelel bvren esehiig shalgah function
        bool verif()
        {
            if( (textBoxProductName.Text.Trim() == "") ||
                //(textBoxThingType.Text.Trim() == "") ||
                (comboBoxProductType.SelectedItem.ToString() == "") ||
                //(textBoxPeopleResp.Text.Trim() == "") ||
                (comboBoxPerson.SelectedItem.ToString() == "") ||
                (pictureBoxThing.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void buttonAddThing_MouseClick(object sender, MouseEventArgs e)
        {
            //medeelel nemeh uildel
            PRODUCT product = new PRODUCT();

            string pName = textBoxProductName.Text;

            //string pType = textBoxThingType.Text; //ene ni text box oos awdg bh ued
            
            string pType = comboBoxProductType.SelectedItem.ToString();
            DateTime mDate = dateManufactured.Value;
            DateTime eDate = dateExpire.Value;


            //string owner = textBoxPeopleResp.Text;//ene ni textbox oos awdag bsn ued
                        
            string owner = comboBoxPerson.Text;//ene ni combobox oos awah ued

            MemoryStream image = new MemoryStream();
            


            if (verif())
            {
                pictureBoxThing.Image.Save(image, pictureBoxThing.Image.RawFormat);

                if (product.insertProduct(pName, pType, mDate, eDate, owner, image))
                {
                    MessageBox.Show("Эд хөрөнгийн бүртгэл амжилттай боллоо.", "Амжилттай", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void comboBoxPerson_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                comboBoxPerson.Items.Clear();
                my_Database db = new my_Database();
                db.openConnection();
                USERSOFTREASURER usersoftreasurer = new USERSOFTREASURER();

                string query = "SELECT * FROM `usersdb`.`users_of_treasurer`;";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                //DataTable table = usersoftreasurer.getPerson(command);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //comboBoxPerson.Items.Add(table.Columns.)
                    comboBoxPerson.Items.Add(reader.GetString("username"));
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            

        }

        private void comboBoxProductType_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                comboBoxProductType.Items.Clear();
                my_Database db = new my_Database();
                db.openConnection();

                string query = "SELECT * FROM `usersdb`.`type_of_product`;";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxProductType.Items.Add(reader.GetString("product_type"));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
