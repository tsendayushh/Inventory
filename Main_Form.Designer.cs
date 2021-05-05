
namespace Treasurer_App
{
    partial class Main_Form
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
            this.buttonEditThing = new System.Windows.Forms.Button();
            this.buttonAddThing = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.buttonEditThing);
            this.panel1.Controls.Add(this.buttonAddThing);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 461);
            this.panel1.TabIndex = 0;
            // 
            // buttonEditThing
            // 
            this.buttonEditThing.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditThing.Location = new System.Drawing.Point(221, 329);
            this.buttonEditThing.Name = "buttonEditThing";
            this.buttonEditThing.Size = new System.Drawing.Size(143, 43);
            this.buttonEditThing.TabIndex = 3;
            this.buttonEditThing.Text = "Мэдээлэл шинэчлэх";
            this.buttonEditThing.UseVisualStyleBackColor = true;
            // 
            // buttonAddThing
            // 
            this.buttonAddThing.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddThing.Location = new System.Drawing.Point(55, 329);
            this.buttonAddThing.Name = "buttonAddThing";
            this.buttonAddThing.Size = new System.Drawing.Size(143, 43);
            this.buttonAddThing.TabIndex = 2;
            this.buttonAddThing.Text = "Эд хөрөнгө бүртгэх";
            this.buttonAddThing.UseVisualStyleBackColor = true;
            this.buttonAddThing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAddThing_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(612, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 267);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(611, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 155);
            this.panel2.TabIndex = 0;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Form";
            this.Text = "Main Form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonEditThing;
        private System.Windows.Forms.Button buttonAddThing;
    }
}