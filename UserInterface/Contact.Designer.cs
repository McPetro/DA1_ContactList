namespace UserInterface
{
    partial class Contact
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
            this.name = new System.Windows.Forms.Label();
            this.nameImput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.phoneNumInput = new System.Windows.Forms.TextBox();
            this.phoneNum = new System.Windows.Forms.Label();
            this.newContactSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(21, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name :";
            // 
            // nameImput
            // 
            this.nameImput.Location = new System.Drawing.Point(110, 25);
            this.nameImput.Name = "nameImput";
            this.nameImput.Size = new System.Drawing.Size(389, 20);
            this.nameImput.TabIndex = 1;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(110, 61);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(389, 20);
            this.addressInput.TabIndex = 3;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(21, 61);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(51, 13);
            this.address.TabIndex = 2;
            this.address.Text = "Address :";
            // 
            // phoneNumInput
            // 
            this.phoneNumInput.Location = new System.Drawing.Point(110, 96);
            this.phoneNumInput.Name = "phoneNumInput";
            this.phoneNumInput.Size = new System.Drawing.Size(389, 20);
            this.phoneNumInput.TabIndex = 5;
            // 
            // phoneNum
            // 
            this.phoneNum.AutoSize = true;
            this.phoneNum.Location = new System.Drawing.Point(21, 96);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(81, 13);
            this.phoneNum.TabIndex = 4;
            this.phoneNum.Text = "Phone Number:";
            // 
            // newContactSubmit
            // 
            this.newContactSubmit.Location = new System.Drawing.Point(370, 144);
            this.newContactSubmit.Name = "newContactSubmit";
            this.newContactSubmit.Size = new System.Drawing.Size(128, 23);
            this.newContactSubmit.TabIndex = 6;
            this.newContactSubmit.Text = "Submit";
            this.newContactSubmit.UseMnemonic = false;
            this.newContactSubmit.UseVisualStyleBackColor = true;
            this.newContactSubmit.Click += new System.EventHandler(this.newContactSubmit_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 189);
            this.Controls.Add(this.newContactSubmit);
            this.Controls.Add(this.phoneNumInput);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.address);
            this.Controls.Add(this.nameImput);
            this.Controls.Add(this.name);
            this.Name = "Contact";
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameImput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox phoneNumInput;
        private System.Windows.Forms.Label phoneNum;
        private System.Windows.Forms.Button newContactSubmit;
    }
}