namespace WinFormTask3._1_Anket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.phoneMTxtb = new System.Windows.Forms.MaskedTextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birthDate = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fileNameTxtb = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(98)))), ((int)(((byte)(122)))));
            this.groupBox1.Controls.Add(this.nameTxtb);
            this.groupBox1.Controls.Add(this.surnameTxtb);
            this.groupBox1.Controls.Add(this.emailTxtb);
            this.groupBox1.Controls.Add(this.phoneMTxtb);
            this.groupBox1.Controls.Add(this.birthDateTimePicker);
            this.groupBox1.Controls.Add(this.birthDate);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.change);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // nameTxtb
            // 
            this.nameTxtb.Location = new System.Drawing.Point(165, 56);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(250, 29);
            this.nameTxtb.TabIndex = 7;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.Location = new System.Drawing.Point(165, 123);
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(250, 29);
            this.surnameTxtb.TabIndex = 7;
            // 
            // emailTxtb
            // 
            this.emailTxtb.Location = new System.Drawing.Point(165, 188);
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(250, 29);
            this.emailTxtb.TabIndex = 7;
            // 
            // phoneMTxtb
            // 
            this.phoneMTxtb.Location = new System.Drawing.Point(165, 250);
            this.phoneMTxtb.Mask = "(994) 00-000-00-00";
            this.phoneMTxtb.Name = "phoneMTxtb";
            this.phoneMTxtb.Size = new System.Drawing.Size(250, 29);
            this.phoneMTxtb.TabIndex = 6;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateTimePicker.Location = new System.Drawing.Point(165, 320);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(250, 21);
            this.birthDateTimePicker.TabIndex = 5;
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.Location = new System.Drawing.Point(28, 320);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(100, 24);
            this.birthDate.TabIndex = 4;
            this.birthDate.Text = "Birth Date";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(28, 250);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(71, 24);
            this.phone.TabIndex = 4;
            this.phone.Text = "Phone";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(28, 188);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(62, 24);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(28, 123);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(94, 24);
            this.surname.TabIndex = 4;
            this.surname.Text = "Surname";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(28, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(65, 24);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.change.Location = new System.Drawing.Point(390, 446);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(100, 29);
            this.change.TabIndex = 2;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.add.Location = new System.Drawing.Point(390, 494);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 26);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(98)))), ((int)(((byte)(122)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(601, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 404);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // fileNameTxtb
            // 
            this.fileNameTxtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.fileNameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameTxtb.Location = new System.Drawing.Point(601, 473);
            this.fileNameTxtb.Name = "fileNameTxtb";
            this.fileNameTxtb.Size = new System.Drawing.Size(293, 26);
            this.fileNameTxtb.TabIndex = 3;
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.loadBtn.Location = new System.Drawing.Point(601, 521);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(132, 43);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.saveBtn.Location = new System.Drawing.Point(759, 521);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(135, 43);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(949, 611);
            this.Controls.Add(this.fileNameTxtb);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox fileNameTxtb;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.MaskedTextBox phoneMTxtb;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.ListBox listBox1;
    }
}

