
namespace Treasurer_App
{
    partial class UpdateAndDeleteProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.pictureBoxThing = new System.Windows.Forms.PictureBox();
            this.buttonOfAddThingsPhoto = new System.Windows.Forms.Button();
            this.imageOfProduct = new System.Windows.Forms.Label();
            this.textBoxFindID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateExpire = new System.Windows.Forms.DateTimePicker();
            this.dateManufactured = new System.Windows.Forms.DateTimePicker();
            this.personResponsibleFor = new System.Windows.Forms.Label();
            this.expiralDate = new System.Windows.Forms.Label();
            this.manufacturedDate = new System.Windows.Forms.Label();
            this.typeOfProduct = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.nameOfProduct = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.comboBoxPerson);
            this.panel1.Controls.Add(this.comboBoxProductType);
            this.panel1.Controls.Add(this.buttonFind);
            this.panel1.Controls.Add(this.buttonDeleteProduct);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.pictureBoxThing);
            this.panel1.Controls.Add(this.buttonOfAddThingsPhoto);
            this.panel1.Controls.Add(this.imageOfProduct);
            this.panel1.Controls.Add(this.textBoxFindID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateExpire);
            this.panel1.Controls.Add(this.dateManufactured);
            this.panel1.Controls.Add(this.personResponsibleFor);
            this.panel1.Controls.Add(this.expiralDate);
            this.panel1.Controls.Add(this.manufacturedDate);
            this.panel1.Controls.Add(this.typeOfProduct);
            this.panel1.Controls.Add(this.textBoxProductName);
            this.panel1.Controls.Add(this.nameOfProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 450);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Location = new System.Drawing.Point(91, 357);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(220, 20);
            this.comboBoxPerson.TabIndex = 43;
            this.comboBoxPerson.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxPerson_MouseClick);
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(91, 155);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(220, 20);
            this.comboBoxProductType.TabIndex = 42;
            this.comboBoxProductType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxProductType_MouseClick);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.ForeColor = System.Drawing.Color.White;
            this.buttonFind.Location = new System.Drawing.Point(245, 21);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(66, 22);
            this.buttonFind.TabIndex = 41;
            this.buttonFind.Text = "Хайх";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFind_MouseClick);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(437, 357);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(160, 63);
            this.buttonDeleteProduct.TabIndex = 40;
            this.buttonDeleteProduct.Text = "Устгах";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(437, 276);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 63);
            this.buttonUpdate.TabIndex = 39;
            this.buttonUpdate.Text = "Шинэчлэх";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // pictureBoxThing
            // 
            this.pictureBoxThing.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBoxThing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxThing.Location = new System.Drawing.Point(416, 18);
            this.pictureBoxThing.Name = "pictureBoxThing";
            this.pictureBoxThing.Size = new System.Drawing.Size(216, 157);
            this.pictureBoxThing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThing.TabIndex = 38;
            this.pictureBoxThing.TabStop = false;
            // 
            // buttonOfAddThingsPhoto
            // 
            this.buttonOfAddThingsPhoto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfAddThingsPhoto.Location = new System.Drawing.Point(416, 181);
            this.buttonOfAddThingsPhoto.Name = "buttonOfAddThingsPhoto";
            this.buttonOfAddThingsPhoto.Size = new System.Drawing.Size(216, 31);
            this.buttonOfAddThingsPhoto.TabIndex = 37;
            this.buttonOfAddThingsPhoto.Text = "Зураг Upload хийх";
            this.buttonOfAddThingsPhoto.UseVisualStyleBackColor = true;
            this.buttonOfAddThingsPhoto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOfAddThingsPhoto_MouseClick);
            // 
            // imageOfProduct
            // 
            this.imageOfProduct.AutoSize = true;
            this.imageOfProduct.BackColor = System.Drawing.Color.Teal;
            this.imageOfProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageOfProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.imageOfProduct.Location = new System.Drawing.Point(342, 72);
            this.imageOfProduct.Name = "imageOfProduct";
            this.imageOfProduct.Size = new System.Drawing.Size(52, 16);
            this.imageOfProduct.TabIndex = 36;
            this.imageOfProduct.Text = "Зураг:";
            // 
            // textBoxFindID
            // 
            this.textBoxFindID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindID.Location = new System.Drawing.Point(172, 21);
            this.textBoxFindID.Name = "textBoxFindID";
            this.textBoxFindID.Size = new System.Drawing.Size(58, 22);
            this.textBoxFindID.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Бүртгэлийн Дугаар:";
            // 
            // dateExpire
            // 
            this.dateExpire.Location = new System.Drawing.Point(91, 292);
            this.dateExpire.Name = "dateExpire";
            this.dateExpire.Size = new System.Drawing.Size(220, 19);
            this.dateExpire.TabIndex = 31;
            // 
            // dateManufactured
            // 
            this.dateManufactured.Location = new System.Drawing.Point(91, 227);
            this.dateManufactured.Name = "dateManufactured";
            this.dateManufactured.Size = new System.Drawing.Size(220, 19);
            this.dateManufactured.TabIndex = 30;
            // 
            // personResponsibleFor
            // 
            this.personResponsibleFor.AutoSize = true;
            this.personResponsibleFor.BackColor = System.Drawing.Color.Teal;
            this.personResponsibleFor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personResponsibleFor.ForeColor = System.Drawing.SystemColors.Control;
            this.personResponsibleFor.Location = new System.Drawing.Point(23, 323);
            this.personResponsibleFor.Name = "personResponsibleFor";
            this.personResponsibleFor.Size = new System.Drawing.Size(148, 16);
            this.personResponsibleFor.TabIndex = 29;
            this.personResponsibleFor.Text = "Хариуцаж буй эзэн:";
            // 
            // expiralDate
            // 
            this.expiralDate.AutoSize = true;
            this.expiralDate.BackColor = System.Drawing.Color.Teal;
            this.expiralDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiralDate.ForeColor = System.Drawing.SystemColors.Control;
            this.expiralDate.Location = new System.Drawing.Point(23, 261);
            this.expiralDate.Name = "expiralDate";
            this.expiralDate.Size = new System.Drawing.Size(135, 16);
            this.expiralDate.TabIndex = 28;
            this.expiralDate.Text = "Хүчинтэй хүгацаа:";
            // 
            // manufacturedDate
            // 
            this.manufacturedDate.AutoSize = true;
            this.manufacturedDate.BackColor = System.Drawing.Color.Teal;
            this.manufacturedDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturedDate.ForeColor = System.Drawing.SystemColors.Control;
            this.manufacturedDate.Location = new System.Drawing.Point(23, 196);
            this.manufacturedDate.Name = "manufacturedDate";
            this.manufacturedDate.Size = new System.Drawing.Size(168, 16);
            this.manufacturedDate.TabIndex = 27;
            this.manufacturedDate.Text = "Үйлдвэрлэгдсэн огноо:";
            // 
            // typeOfProduct
            // 
            this.typeOfProduct.AutoSize = true;
            this.typeOfProduct.BackColor = System.Drawing.Color.Teal;
            this.typeOfProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.typeOfProduct.Location = new System.Drawing.Point(23, 132);
            this.typeOfProduct.Name = "typeOfProduct";
            this.typeOfProduct.Size = new System.Drawing.Size(55, 16);
            this.typeOfProduct.TabIndex = 26;
            this.typeOfProduct.Text = "Төрөл:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(91, 95);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(220, 22);
            this.textBoxProductName.TabIndex = 25;
            // 
            // nameOfProduct
            // 
            this.nameOfProduct.AutoSize = true;
            this.nameOfProduct.BackColor = System.Drawing.Color.Teal;
            this.nameOfProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.nameOfProduct.Location = new System.Drawing.Point(23, 66);
            this.nameOfProduct.Name = "nameOfProduct";
            this.nameOfProduct.Size = new System.Drawing.Size(134, 16);
            this.nameOfProduct.TabIndex = 24;
            this.nameOfProduct.Text = "Эд хөрөнгийн нэр:";
            // 
            // UpdateAndDeleteProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateAndDeleteProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAndDeleteProductForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label personResponsibleFor;
        private System.Windows.Forms.Label expiralDate;
        private System.Windows.Forms.Label manufacturedDate;
        private System.Windows.Forms.Label typeOfProduct;
        private System.Windows.Forms.Label nameOfProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonOfAddThingsPhoto;
        private System.Windows.Forms.Label imageOfProduct;
        internal System.Windows.Forms.TextBox textBoxFindID;
        internal System.Windows.Forms.TextBox textBoxProductName;
        internal System.Windows.Forms.DateTimePicker dateExpire;
        internal System.Windows.Forms.DateTimePicker dateManufactured;
        internal System.Windows.Forms.PictureBox pictureBoxThing;
        internal System.Windows.Forms.ComboBox comboBoxProductType;
        internal System.Windows.Forms.ComboBox comboBoxPerson;
    }
}