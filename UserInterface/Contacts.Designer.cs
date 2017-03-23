namespace UserInterface
{
    partial class Contacts
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
            this.label1 = new System.Windows.Forms.Label();
            this.contactList = new System.Windows.Forms.ListBox();
            this.pplName = new System.Windows.Forms.Label();
            this.phnNumber = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.shwAddr = new System.Windows.Forms.Label();
            this.shwPhnNum = new System.Windows.Forms.Label();
            this.shwName = new System.Windows.Forms.Label();
            this.addModifyContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacts";
            // 
            // contactList
            // 
            this.contactList.FormattingEnabled = true;
            this.contactList.Location = new System.Drawing.Point(24, 58);
            this.contactList.Name = "contactList";
            this.contactList.Size = new System.Drawing.Size(272, 277);
            this.contactList.TabIndex = 1;
            this.contactList.SelectedIndexChanged += new System.EventHandler(this.contactList_SelectedIndexChanged);
            // 
            // pplName
            // 
            this.pplName.AutoSize = true;
            this.pplName.Location = new System.Drawing.Point(315, 59);
            this.pplName.Name = "pplName";
            this.pplName.Size = new System.Drawing.Size(35, 13);
            this.pplName.TabIndex = 2;
            this.pplName.Text = "Name";
            // 
            // phnNumber
            // 
            this.phnNumber.AutoSize = true;
            this.phnNumber.Location = new System.Drawing.Point(315, 90);
            this.phnNumber.Name = "phnNumber";
            this.phnNumber.Size = new System.Drawing.Size(76, 13);
            this.phnNumber.TabIndex = 3;
            this.phnNumber.Text = "Phone number";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(315, 130);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(48, 13);
            this.address.TabIndex = 4;
            this.address.Text = "Address:";
            // 
            // shwAddr
            // 
            this.shwAddr.AutoSize = true;
            this.shwAddr.Location = new System.Drawing.Point(400, 129);
            this.shwAddr.Name = "shwAddr";
            this.shwAddr.Size = new System.Drawing.Size(48, 13);
            this.shwAddr.TabIndex = 7;
            this.shwAddr.Text = "Address:";
            // 
            // shwPhnNum
            // 
            this.shwPhnNum.AutoSize = true;
            this.shwPhnNum.Location = new System.Drawing.Point(400, 89);
            this.shwPhnNum.Name = "shwPhnNum";
            this.shwPhnNum.Size = new System.Drawing.Size(76, 13);
            this.shwPhnNum.TabIndex = 6;
            this.shwPhnNum.Text = "Phone number";
            // 
            // shwName
            // 
            this.shwName.AutoSize = true;
            this.shwName.Location = new System.Drawing.Point(400, 58);
            this.shwName.Name = "shwName";
            this.shwName.Size = new System.Drawing.Size(35, 13);
            this.shwName.TabIndex = 5;
            this.shwName.Text = "Name";
            // 
            // addModifyContact
            // 
            this.addModifyContact.Location = new System.Drawing.Point(189, 354);
            this.addModifyContact.Name = "addModifyContact";
            this.addModifyContact.Size = new System.Drawing.Size(106, 23);
            this.addModifyContact.TabIndex = 8;
            this.addModifyContact.Text = "Add";
            this.addModifyContact.UseVisualStyleBackColor = true;
            this.addModifyContact.Click += new System.EventHandler(this.addModifyContact_Click);
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 405);
            this.Controls.Add(this.addModifyContact);
            this.Controls.Add(this.shwAddr);
            this.Controls.Add(this.shwPhnNum);
            this.Controls.Add(this.shwName);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phnNumber);
            this.Controls.Add(this.pplName);
            this.Controls.Add(this.contactList);
            this.Controls.Add(this.label1);
            this.Name = "Contacts";
            this.Text = "Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox contactList;
        private System.Windows.Forms.Label pplName;
        private System.Windows.Forms.Label phnNumber;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label shwAddr;
        private System.Windows.Forms.Label shwPhnNum;
        private System.Windows.Forms.Label shwName;
        private System.Windows.Forms.Button addModifyContact;
    }
}

