
namespace Treasurer_App
{
    partial class AddThingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddThingForm));
            this.nameOfProduct = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.typeOfProduct = new System.Windows.Forms.Label();
            this.manufacturedDate = new System.Windows.Forms.Label();
            this.expiralDate = new System.Windows.Forms.Label();
            this.personResponsibleFor = new System.Windows.Forms.Label();
            this.imageOfProduct = new System.Windows.Forms.Label();
            this.dateManufactured = new System.Windows.Forms.DateTimePicker();
            this.dateExpire = new System.Windows.Forms.DateTimePicker();
            this.buttonOfAddThingsPhoto = new System.Windows.Forms.Button();
            this.pictureBoxThing = new System.Windows.Forms.PictureBox();
            this.buttonAddThing = new System.Windows.Forms.Button();
            this.buttonCancelAdd = new System.Windows.Forms.Button();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThing)).BeginInit();
            this.SuspendLayout();
            // 
            // nameOfProduct
            // 
            this.nameOfProduct.AutoSize = true;
            this.nameOfProduct.BackColor = System.Drawing.Color.Teal;
            this.nameOfProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.nameOfProduct.Location = new System.Drawing.Point(12, 9);
            this.nameOfProduct.Name = "nameOfProduct";
            this.nameOfProduct.Size = new System.Drawing.Size(134, 16);
            this.nameOfProduct.TabIndex = 5;
            this.nameOfProduct.Text = "Эд хөрөнгийн нэр:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(80, 38);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(220, 22);
            this.textBoxProductName.TabIndex = 10;
            // 
            // typeOfProduct
            // 
            this.typeOfProduct.AutoSize = true;
            this.typeOfProduct.BackColor = System.Drawing.Color.Teal;
            this.typeOfProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.typeOfProduct.Location = new System.Drawing.Point(12, 75);
            this.typeOfProduct.Name = "typeOfProduct";
            this.typeOfProduct.Size = new System.Drawing.Size(55, 16);
            this.typeOfProduct.TabIndex = 11;
            this.typeOfProduct.Text = "Төрөл:";
            // 
            // manufacturedDate
            // 
            this.manufacturedDate.AutoSize = true;
            this.manufacturedDate.BackColor = System.Drawing.Color.Teal;
            this.manufacturedDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturedDate.ForeColor = System.Drawing.SystemColors.Control;
            this.manufacturedDate.Location = new System.Drawing.Point(12, 139);
            this.manufacturedDate.Name = "manufacturedDate";
            this.manufacturedDate.Size = new System.Drawing.Size(168, 16);
            this.manufacturedDate.TabIndex = 12;
            this.manufacturedDate.Text = "Үйлдвэрлэгдсэн огноо:";
            // 
            // expiralDate
            // 
            this.expiralDate.AutoSize = true;
            this.expiralDate.BackColor = System.Drawing.Color.Teal;
            this.expiralDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiralDate.ForeColor = System.Drawing.SystemColors.Control;
            this.expiralDate.Location = new System.Drawing.Point(12, 204);
            this.expiralDate.Name = "expiralDate";
            this.expiralDate.Size = new System.Drawing.Size(135, 16);
            this.expiralDate.TabIndex = 13;
            this.expiralDate.Text = "Хүчинтэй хүгацаа:";
            // 
            // personResponsibleFor
            // 
            this.personResponsibleFor.AutoSize = true;
            this.personResponsibleFor.BackColor = System.Drawing.Color.Teal;
            this.personResponsibleFor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personResponsibleFor.ForeColor = System.Drawing.SystemColors.Control;
            this.personResponsibleFor.Location = new System.Drawing.Point(12, 266);
            this.personResponsibleFor.Name = "personResponsibleFor";
            this.personResponsibleFor.Size = new System.Drawing.Size(148, 16);
            this.personResponsibleFor.TabIndex = 14;
            this.personResponsibleFor.Text = "Хариуцаж буй эзэн:";
            // 
            // imageOfProduct
            // 
            this.imageOfProduct.AutoSize = true;
            this.imageOfProduct.BackColor = System.Drawing.Color.Teal;
            this.imageOfProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageOfProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.imageOfProduct.Location = new System.Drawing.Point(13, 364);
            this.imageOfProduct.Name = "imageOfProduct";
            this.imageOfProduct.Size = new System.Drawing.Size(52, 16);
            this.imageOfProduct.TabIndex = 15;
            this.imageOfProduct.Text = "Зураг:";
            // 
            // dateManufactured
            // 
            this.dateManufactured.Location = new System.Drawing.Point(80, 170);
            this.dateManufactured.Name = "dateManufactured";
            this.dateManufactured.Size = new System.Drawing.Size(220, 19);
            this.dateManufactured.TabIndex = 16;
            // 
            // dateExpire
            // 
            this.dateExpire.Location = new System.Drawing.Point(80, 235);
            this.dateExpire.Name = "dateExpire";
            this.dateExpire.Size = new System.Drawing.Size(220, 19);
            this.dateExpire.TabIndex = 17;
            // 
            // buttonOfAddThingsPhoto
            // 
            this.buttonOfAddThingsPhoto.Location = new System.Drawing.Point(279, 337);
            this.buttonOfAddThingsPhoto.Name = "buttonOfAddThingsPhoto";
            this.buttonOfAddThingsPhoto.Size = new System.Drawing.Size(21, 91);
            this.buttonOfAddThingsPhoto.TabIndex = 18;
            this.buttonOfAddThingsPhoto.Text = "///";
            this.buttonOfAddThingsPhoto.UseVisualStyleBackColor = true;
            this.buttonOfAddThingsPhoto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOfAddThingsPhoto_MouseClick);
            // 
            // pictureBoxThing
            // 
            this.pictureBoxThing.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBoxThing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxThing.Location = new System.Drawing.Point(121, 337);
            this.pictureBoxThing.Name = "pictureBoxThing";
            this.pictureBoxThing.Size = new System.Drawing.Size(140, 91);
            this.pictureBoxThing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThing.TabIndex = 20;
            this.pictureBoxThing.TabStop = false;
            // 
            // buttonAddThing
            // 
            this.buttonAddThing.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAddThing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddThing.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddThing.ForeColor = System.Drawing.Color.White;
            this.buttonAddThing.Location = new System.Drawing.Point(49, 454);
            this.buttonAddThing.Name = "buttonAddThing";
            this.buttonAddThing.Size = new System.Drawing.Size(93, 38);
            this.buttonAddThing.TabIndex = 21;
            this.buttonAddThing.Text = "Нэмэх";
            this.buttonAddThing.UseVisualStyleBackColor = false;
            this.buttonAddThing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAddThing_MouseClick);
            // 
            // buttonCancelAdd
            // 
            this.buttonCancelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAdd.ForeColor = System.Drawing.Color.White;
            this.buttonCancelAdd.Location = new System.Drawing.Point(181, 454);
            this.buttonCancelAdd.Name = "buttonCancelAdd";
            this.buttonCancelAdd.Size = new System.Drawing.Size(93, 38);
            this.buttonCancelAdd.TabIndex = 22;
            this.buttonCancelAdd.Text = "Цуцлах";
            this.buttonCancelAdd.UseVisualStyleBackColor = false;
            this.buttonCancelAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCancelAdd_MouseClick);
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Location = new System.Drawing.Point(80, 301);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(220, 20);
            this.comboBoxPerson.TabIndex = 24;
            this.comboBoxPerson.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxPerson_MouseClick);
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(80, 103);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(220, 20);
            this.comboBoxProductType.TabIndex = 25;
            this.comboBoxProductType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxProductType_MouseClick);
            // 
            // AddThingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(334, 503);
            this.Controls.Add(this.comboBoxProductType);
            this.Controls.Add(this.comboBoxPerson);
            this.Controls.Add(this.buttonCancelAdd);
            this.Controls.Add(this.buttonAddThing);
            this.Controls.Add(this.pictureBoxThing);
            this.Controls.Add(this.buttonOfAddThingsPhoto);
            this.Controls.Add(this.dateExpire);
            this.Controls.Add(this.dateManufactured);
            this.Controls.Add(this.imageOfProduct);
            this.Controls.Add(this.personResponsibleFor);
            this.Controls.Add(this.expiralDate);
            this.Controls.Add(this.manufacturedDate);
            this.Controls.Add(this.typeOfProduct);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.nameOfProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddThingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эд хөрөнгө нэмэх";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameOfProduct;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label typeOfProduct;
        private System.Windows.Forms.Label manufacturedDate;
        private System.Windows.Forms.Label expiralDate;
        private System.Windows.Forms.Label personResponsibleFor;
        private System.Windows.Forms.Label imageOfProduct;
        private System.Windows.Forms.DateTimePicker dateManufactured;
        private System.Windows.Forms.DateTimePicker dateExpire;
        private System.Windows.Forms.Button buttonOfAddThingsPhoto;
        private System.Windows.Forms.PictureBox pictureBoxThing;
        private System.Windows.Forms.Button buttonAddThing;
        private System.Windows.Forms.Button buttonCancelAdd;
        private System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.ComboBox comboBoxProductType;
    }
}