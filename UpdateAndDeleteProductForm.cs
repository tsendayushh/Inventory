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
    public partial class UpdateAndDeleteProductForm : Form
    {
        public UpdateAndDeleteProductForm()
        {
            InitializeComponent();
        }

        private void buttonOfAddThingsPhoto_MouseClick(object sender, MouseEventArgs e)
        {
            //com oos zurag awah uildel
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxThing.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonFind_MouseClick(object sender, MouseEventArgs e)
        {
            // id gaar ni product haih uildel
            int id = Convert.ToInt32(textBoxFindID.Text);
            MySqlCommand command = new MySqlCommand("SELECT `product`.`pname`, `product`.`ptype`, `product`.`date_manufactured`, `product`.`date_expire`, `product`.`person_responsible_for`, `product`.`image` FROM `usersdb`.`product` WHERE product_id = "+id );

            DataTable table = product.getProducts(command);

            if(table.Rows.Count > 0)
            {
                textBoxProductName.Text = table.Rows[0]["pname"].ToString();
                textBoxThingType.Text = table.Rows[0]["ptype"].ToString();

                dateManufactured.Value = (DateTime)table.Rows[0]["date_manufactured"];
                dateExpire.Value = (DateTime)table.Rows[0]["date_expire"];

                textBoxPeopleResp.Text = table.Rows[0]["person_responsible_for"].ToString();

                byte[] img = (byte[])table.Rows[0]["image"];
                MemoryStream image = new MemoryStream(img);
                pictureBoxThing.Image = Image.FromStream(image);

            }
        }

        // medeelel bvren esehiig shalgah function
        bool verif()
        {
            if ((textBoxProductName.Text.Trim() == "") ||
                (textBoxThingType.Text.Trim() == "") ||
                (textBoxPeopleResp.Text.Trim() == "") ||
                (pictureBoxThing.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        PRODUCT product = new PRODUCT();
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //product in medeelliig shinechleh

            int id = Convert.ToInt32(textBoxFindID.Text);
            string pName = textBoxProductName.Text;
            string pType = textBoxThingType.Text;
            DateTime mDate = dateManufactured.Value;
            DateTime eDate = dateExpire.Value;
            string owner = textBoxPeopleResp.Text;

            MemoryStream image = new MemoryStream();



            if (verif())
            {
                    pictureBoxThing.Image.Save(image, pictureBoxThing.Image.RawFormat);

                    if (product.updateProduct(id, pName, pType, mDate, eDate, owner, image))
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

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            //product iig ustgah 

            int id = Convert.ToInt32(textBoxFindID.Text);
            if(MessageBox.Show("Та энэ эд хогшлыг бүртгэлээс устгахдаа итгэлтэй байна уу?", "Эд хогшил устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                product.deleteProduct(id);

                textBoxFindID.Text = "";
                textBoxThingType.Text = "";
                dateManufactured.Value = DateTime.Now;
                dateExpire.Value = DateTime.Now;
                textBoxPeopleResp.Text = "";
                pictureBoxThing.Image = null;

                MessageBox.Show("Эд хогшил бүртгэлээс устгагдлаа.", "Эд хогшил устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Эд хогшил бүртгэлээс устсангүй.", "Эд хогшил устгах", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
