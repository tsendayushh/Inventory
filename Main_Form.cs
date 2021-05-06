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

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // songogdsn item iig shine form deer gargaj irne ter ni edit bolon remove hiih bolomjtoi baih
            UpdateAndDeleteProductForm updateAndDelete = new UpdateAndDeleteProductForm();

            updateAndDelete.textBoxFindID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            updateAndDelete.textBoxProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            updateAndDelete.textBoxThingType.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            updateAndDelete.dateManufactured.Value = ( DateTime )dataGridView1.CurrentRow.Cells[3].Value;

            updateAndDelete.dateExpire.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;

            updateAndDelete.textBoxPeopleResp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            byte[] img;
            img = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream image = new MemoryStream(img);
            updateAndDelete.pictureBoxThing.Image = Image.FromStream(image);
            updateAndDelete.Show();
        }

        private void buttonEditThing_MouseClick(object sender, MouseEventArgs e)
        {
            // songogdsn item iig shine form deer gargaj irne ter ni edit bolon remove hiih bolomjtoi baih
            UpdateAndDeleteProductForm updateAndDelete = new UpdateAndDeleteProductForm();

            updateAndDelete.textBoxFindID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            updateAndDelete.textBoxProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            updateAndDelete.textBoxThingType.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            updateAndDelete.dateManufactured.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            updateAndDelete.dateExpire.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;

            updateAndDelete.textBoxPeopleResp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

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
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            // hvniii medeeleltei database table iig gargah form
            PeopleImformationForm peopleImformation = new PeopleImformationForm();
            peopleImformation.Show(this);
        }
    }
}
