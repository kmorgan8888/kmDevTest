namespace KMDevTest
{
    partial class Form1
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
            this.custListLabel = new System.Windows.Forms.Label();
            this.nameEnter = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.custListBox = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.orderHistory = new System.Windows.Forms.ComboBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.custEdit = new System.Windows.Forms.ComboBox();
            this.editLabel = new System.Windows.Forms.Label();
            this.showInventory = new System.Windows.Forms.Button();
            this.addNewCust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custListLabel
            // 
            this.custListLabel.AutoSize = true;
            this.custListLabel.Location = new System.Drawing.Point(26, 9);
            this.custListLabel.Name = "custListLabel";
            this.custListLabel.Size = new System.Drawing.Size(110, 13);
            this.custListLabel.TabIndex = 0;
            this.custListLabel.Text = "Current Customer List:";
            this.custListLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameEnter
            // 
            this.nameEnter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameEnter.Location = new System.Drawing.Point(119, 277);
            this.nameEnter.Name = "nameEnter";
            this.nameEnter.Size = new System.Drawing.Size(372, 20);
            this.nameEnter.TabIndex = 4;
            this.nameEnter.Visible = false;
            this.nameEnter.TextChanged += new System.EventHandler(this.nameEnter_TextChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(119, 306);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(372, 20);
            this.address.TabIndex = 5;
            this.address.Visible = false;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(119, 332);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(372, 20);
            this.email.TabIndex = 6;
            this.email.Visible = false;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(119, 358);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(372, 20);
            this.phone.TabIndex = 7;
            this.phone.Visible = false;
            this.phone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(23, 284);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(63, 13);
            this.namelabel.TabIndex = 8;
            this.namelabel.Text = "Enter Name";
            this.namelabel.Visible = false;
            this.namelabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(23, 313);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(73, 13);
            this.addresslabel.TabIndex = 9;
            this.addresslabel.Text = "Enter Address";
            this.addresslabel.Visible = false;
            this.addresslabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(23, 339);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(60, 13);
            this.emaillabel.TabIndex = 10;
            this.emaillabel.Text = "Enter Email";
            this.emaillabel.Visible = false;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(23, 365);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(66, 13);
            this.phonelabel.TabIndex = 11;
            this.phonelabel.Text = "Enter Phone";
            this.phonelabel.Visible = false;
            this.phonelabel.Click += new System.EventHandler(this.phonelabel_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(507, 356);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // custListBox
            // 
            this.custListBox.Location = new System.Drawing.Point(26, 48);
            this.custListBox.Multiline = true;
            this.custListBox.Name = "custListBox";
            this.custListBox.Size = new System.Drawing.Size(497, 187);
            this.custListBox.TabIndex = 13;
            this.custListBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Location = new System.Drawing.Point(26, 32);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(281, 13);
            this.textBoxLabel.TabIndex = 14;
            this.textBoxLabel.Text = "Name        Address        Email        Phone        Inventory    ";
            // 
            // orderHistory
            // 
            this.orderHistory.FormattingEnabled = true;
            this.orderHistory.Location = new System.Drawing.Point(529, 64);
            this.orderHistory.Name = "orderHistory";
            this.orderHistory.Size = new System.Drawing.Size(201, 21);
            this.orderHistory.TabIndex = 16;
            this.orderHistory.SelectedIndexChanged += new System.EventHandler(this.orderHistory_SelectedIndexChanged);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(529, 48);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(163, 13);
            this.orderLabel.TabIndex = 17;
            this.orderLabel.Text = "Select Customer for Order History";
            // 
            // custEdit
            // 
            this.custEdit.FormattingEnabled = true;
            this.custEdit.Location = new System.Drawing.Point(186, 241);
            this.custEdit.Name = "custEdit";
            this.custEdit.Size = new System.Drawing.Size(171, 21);
            this.custEdit.TabIndex = 18;
            this.custEdit.SelectedIndexChanged += new System.EventHandler(this.custEdit_SelectedIndexChanged);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(116, 246);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(64, 13);
            this.editLabel.TabIndex = 19;
            this.editLabel.Text = "Edit Existing";
            // 
            // showInventory
            // 
            this.showInventory.Location = new System.Drawing.Point(529, 212);
            this.showInventory.Name = "showInventory";
            this.showInventory.Size = new System.Drawing.Size(201, 23);
            this.showInventory.TabIndex = 20;
            this.showInventory.Text = "Show Inventory";
            this.showInventory.UseVisualStyleBackColor = true;
            this.showInventory.Click += new System.EventHandler(this.showInventory_Click);
            // 
            // addNewCust
            // 
            this.addNewCust.Location = new System.Drawing.Point(26, 242);
            this.addNewCust.Name = "addNewCust";
            this.addNewCust.Size = new System.Drawing.Size(75, 23);
            this.addNewCust.TabIndex = 21;
            this.addNewCust.Text = "Add New";
            this.addNewCust.UseVisualStyleBackColor = true;
            this.addNewCust.Click += new System.EventHandler(this.addNewCust_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 398);
            this.Controls.Add(this.addNewCust);
            this.Controls.Add(this.showInventory);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.custEdit);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.orderHistory);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.custListBox);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.nameEnter);
            this.Controls.Add(this.custListLabel);
            this.Name = "Form1";
            this.Text = "Kevin Morgan\'s Customer Information Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custListLabel;
        private System.Windows.Forms.TextBox nameEnter;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox custListBox;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.ComboBox orderHistory;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.ComboBox custEdit;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Button showInventory;
        private System.Windows.Forms.Button addNewCust;
    }
}

