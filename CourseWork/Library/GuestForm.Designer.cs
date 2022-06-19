namespace Library
{
    partial class GuestForm
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
            this.btn_GuesrForm_Exit = new System.Windows.Forms.Button();
            this.textBoxGuestName = new System.Windows.Forms.TextBox();
            this.labelGuestName = new System.Windows.Forms.Label();
            this.dateTimePicker_GuestAge = new System.Windows.Forms.DateTimePicker();
            this.label_Guest_age = new System.Windows.Forms.Label();
            this.checkBoxGuest_student = new System.Windows.Forms.CheckBox();
            this.buttonGuestCreate = new System.Windows.Forms.Button();
            this.button_inputUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GuesrForm_Exit
            // 
            this.btn_GuesrForm_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_GuesrForm_Exit.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_GuesrForm_Exit.Location = new System.Drawing.Point(519, 419);
            this.btn_GuesrForm_Exit.Name = "btn_GuesrForm_Exit";
            this.btn_GuesrForm_Exit.Size = new System.Drawing.Size(331, 107);
            this.btn_GuesrForm_Exit.TabIndex = 2;
            this.btn_GuesrForm_Exit.Text = "EXIT\r\n\r\n";
            this.btn_GuesrForm_Exit.UseVisualStyleBackColor = false;
            this.btn_GuesrForm_Exit.Click += new System.EventHandler(this.btn_GuesrForm_Exit_Click);
            // 
            // textBoxGuestName
            // 
            this.textBoxGuestName.Font = new System.Drawing.Font("Tempus Sans ITC", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxGuestName.Location = new System.Drawing.Point(55, 89);
            this.textBoxGuestName.Multiline = true;
            this.textBoxGuestName.Name = "textBoxGuestName";
            this.textBoxGuestName.Size = new System.Drawing.Size(305, 95);
            this.textBoxGuestName.TabIndex = 3;
            // 
            // labelGuestName
            // 
            this.labelGuestName.AutoSize = true;
            this.labelGuestName.Font = new System.Drawing.Font("Tempus Sans ITC", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelGuestName.Location = new System.Drawing.Point(55, 32);
            this.labelGuestName.Name = "labelGuestName";
            this.labelGuestName.Size = new System.Drawing.Size(127, 42);
            this.labelGuestName.TabIndex = 4;
            this.labelGuestName.Text = "NAME:";
            // 
            // dateTimePicker_GuestAge
            // 
            this.dateTimePicker_GuestAge.CalendarFont = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_GuestAge.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimePicker_GuestAge.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker_GuestAge.Location = new System.Drawing.Point(55, 274);
            this.dateTimePicker_GuestAge.Name = "dateTimePicker_GuestAge";
            this.dateTimePicker_GuestAge.Size = new System.Drawing.Size(305, 31);
            this.dateTimePicker_GuestAge.TabIndex = 37;
            // 
            // label_Guest_age
            // 
            this.label_Guest_age.AutoSize = true;
            this.label_Guest_age.Font = new System.Drawing.Font("Tempus Sans ITC", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_Guest_age.Location = new System.Drawing.Point(55, 225);
            this.label_Guest_age.Name = "label_Guest_age";
            this.label_Guest_age.Size = new System.Drawing.Size(187, 42);
            this.label_Guest_age.TabIndex = 38;
            this.label_Guest_age.Text = "BIRTHDAY:\r\n";
            // 
            // checkBoxGuest_student
            // 
            this.checkBoxGuest_student.AutoSize = true;
            this.checkBoxGuest_student.Font = new System.Drawing.Font("Tempus Sans ITC", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.checkBoxGuest_student.Location = new System.Drawing.Point(67, 419);
            this.checkBoxGuest_student.Name = "checkBoxGuest_student";
            this.checkBoxGuest_student.Size = new System.Drawing.Size(222, 57);
            this.checkBoxGuest_student.TabIndex = 40;
            this.checkBoxGuest_student.Text = "is Student";
            this.checkBoxGuest_student.UseVisualStyleBackColor = true;
            // 
            // buttonGuestCreate
            // 
            this.buttonGuestCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonGuestCreate.Font = new System.Drawing.Font("Tempus Sans ITC", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonGuestCreate.Location = new System.Drawing.Point(519, 247);
            this.buttonGuestCreate.Name = "buttonGuestCreate";
            this.buttonGuestCreate.Size = new System.Drawing.Size(331, 107);
            this.buttonGuestCreate.TabIndex = 41;
            this.buttonGuestCreate.Text = "CREATE NEW";
            this.buttonGuestCreate.UseVisualStyleBackColor = false;
            this.buttonGuestCreate.Click += new System.EventHandler(this.buttonGuestCreate_Click);
            // 
            // button_inputUser
            // 
            this.button_inputUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_inputUser.Font = new System.Drawing.Font("Tempus Sans ITC", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_inputUser.Location = new System.Drawing.Point(519, 77);
            this.button_inputUser.Name = "button_inputUser";
            this.button_inputUser.Size = new System.Drawing.Size(331, 107);
            this.button_inputUser.TabIndex = 42;
            this.button_inputUser.Text = "INPUT USER";
            this.button_inputUser.UseVisualStyleBackColor = false;
            this.button_inputUser.Click += new System.EventHandler(this.button_inputUser_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(880, 555);
            this.Controls.Add(this.button_inputUser);
            this.Controls.Add(this.buttonGuestCreate);
            this.Controls.Add(this.checkBoxGuest_student);
            this.Controls.Add(this.label_Guest_age);
            this.Controls.Add(this.dateTimePicker_GuestAge);
            this.Controls.Add(this.labelGuestName);
            this.Controls.Add(this.textBoxGuestName);
            this.Controls.Add(this.btn_GuesrForm_Exit);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GuesrForm_Exit;
        private System.Windows.Forms.TextBox textBoxGuestName;
        private System.Windows.Forms.Label labelGuestName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_GuestAge;
        private System.Windows.Forms.Label label_Guest_age;
        private System.Windows.Forms.CheckBox checkBoxGuest_student;
        private System.Windows.Forms.Button buttonGuestCreate;
        private System.Windows.Forms.Button button_inputUser;
    }
}