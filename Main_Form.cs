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
    public partial class Main_Form : Form
    {

        
        public Main_Form()
        {
            InitializeComponent();
            if (dataGridView1.SelectedCells.Count > 0)
            { buttonEditThing.Enabled = true; }
            else { buttonEditThing.Enabled = false; }
        }

        private void buttonAddThing_MouseClick(object sender, MouseEventArgs e)
        {
            AddThingForm addThingF = new AddThingForm();
            addThingF.Show(this);
        }

        PRODUCT product = new PRODUCT();
        my_Database db = new my_Database();
        private void buttonRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            //datagridview iig datatai bolgonooo ahaha
            MySqlCommand command = new MySqlCommand("SELECT * FROM usersdb.product;");

            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.DataSource = product.getProducts(command);

            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[6];

            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;

            labelSearchResult.Text = "Нийт илэрц: " + dataGridView1.Rows.Count;

            textBoxSearch.Text = "";

            /*
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[1].HeaderText = "Нэр";
            dataGridView1.Columns[2].HeaderText = "Төрөл";
            dataGridView1.Columns[3].HeaderText = "Үйлдвэрлэгдсэн огноо";
            dataGridView1.Columns[4].HeaderText = "Хүчинтэй огноо";
            dataGridView1.Columns[5].HeaderText = "Хариуцаж буй эзэн";
            dataGridView1.Columns[6].HeaderText = "Зураг";
            */
            if (dataGridView1.SelectedCells.Count > 0)
            { buttonEditThing.Enabled = true; }
            else { buttonEditThing.Enabled = false; }

            
            if(dataGridView1 != null)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            updateAndDeleteFormDataSet();
        }

        private void buttonEditThing_MouseClick(object sender, MouseEventArgs e)
        {
            updateAndDeleteFormDataSet();            
        }
        public void updateAndDeleteFormDataSet()
        {
            // songogdsn item iig shine form deer gargaj irne ter ni edit bolon remove hiih bolomjtoi baih
            UpdateAndDeleteProductForm updateAndDelete = new UpdateAndDeleteProductForm();

            updateAndDelete.textBoxFindID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            updateAndDelete.textBoxProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //updateAndDelete.textBoxThingType.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateAndDelete.comboBoxProductType.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            updateAndDelete.dateManufactured.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            updateAndDelete.dateExpire.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;

            //updateAndDelete.textBoxPeopleResp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateAndDelete.comboBoxPerson.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            byte[] img;
            img = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream image = new MemoryStream(img);
            updateAndDelete.pictureBoxThing.Image = Image.FromStream(image);
            updateAndDelete.Show();
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {
            //oruulsn ugeer haih function

            string query = "SELECT * FROM `usersdb`.`product`WHERE CONCAT(`product_id`,`pname`,`ptype`,`person_responsible_for`) LIKE '%" + textBoxSearch.Text + "%';";
            MySqlCommand command = new MySqlCommand(query);
            fillDataGrid(command);

            labelSearchResult.Text = "Нийт илэрц: " + dataGridView1.Rows.Count;
        }

        public void fillDataGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.DataSource = product.getProducts(command);

            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[6];

            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;
            /*
             * product iin expire bolsn ued ulaan aar haruulah
            int yearNow = DateTime.Now.Year;
            int yearExpireProduct = dataGridView1.
            
            dataGridView1.DefaultCellStyle.BackColor
            */


            dataGridView1.AutoResizeColumns();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            // hvniii medeeleltei database table iig gargah form
            PeopleImformationForm peopleImformation = new PeopleImformationForm();
            peopleImformation.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // application oos garah
            if(MessageBox.Show("Та аппликейшнээс гарахдаа итгэлтэй байна уу?", "Гарах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Дараа дахин уулзатлаа түр баяртай", "Баяртай", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            /*try
            {
                DataGridViewComboBoxCell dataGridViewCombo = new DataGridViewComboBoxCell();
                if(e.ColumnIndex == 5)
                {
                    dataGridViewCombo.Items.Clear();
                    my_Database db = new my_Database();
                    db.openConnection();

                    string query = "SELECT * FROM `usersdb`.`users_of_treasurer`;";

                    MySqlCommand command = new MySqlCommand(query, db.getConnection());

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        dataGridViewCombo.Items.Add(reader.GetString("username"));
                    }
                    dataGridView1.CurrentCell.Value = dataGridViewCombo;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }*/


            /*
             * datagrid iin username heseg deer selected hiigdsn ued quick information tsonh garch irdeg uildel
             * 
            while (dataGridView1.Columns[5].Selected == true)
            {

                QuickPersonalInfoForm quickPersonal = new QuickPersonalInfoForm();
                quickPersonal.textBoxFirstame.Text = ;
                quickPersonal.textBoxLastname.Text = ;
                quickPersonal.textBoxEmailaAddress.Text = ;
                quickPersonal.Show(this);

            }
            */
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "date_expire")
            {
                DateTime today = DateTime.Today;
                var expireDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["date_expire"].Value);
                if ( today > expireDate )
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Red;
                    // e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }
    }
}
