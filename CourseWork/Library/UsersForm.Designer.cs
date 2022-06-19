namespace Library
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.btn_UsersForm_Exit = new System.Windows.Forms.Button();
            this.labelUsersListName = new System.Windows.Forms.Label();
            this.usersList = new System.Windows.Forms.ListBox();
            this.labelEventLogListName = new System.Windows.Forms.Label();
            this.eventLogList = new System.Windows.Forms.ListBox();
            this.btn_usersList_Add = new System.Windows.Forms.Button();
            this.btn_usersListRemake = new System.Windows.Forms.Button();
            this.btn_usersListDelete = new System.Windows.Forms.Button();
            this.label_userListName = new System.Windows.Forms.Label();
            this.textBox_userList_Name = new System.Windows.Forms.TextBox();
            this.dateTimePicker_userListDateAge = new System.Windows.Forms.DateTimePicker();
            this.label_userListDate_age = new System.Windows.Forms.Label();
            this.door1_userListForm = new System.Windows.Forms.PictureBox();
            this.checkBox_userList_student = new System.Windows.Forms.CheckBox();
            this.label_userList_student = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.door1_userListForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_UsersForm_Exit
            // 
            this.btn_UsersForm_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_UsersForm_Exit.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_UsersForm_Exit.Location = new System.Drawing.Point(71, 610);
            this.btn_UsersForm_Exit.Name = "btn_UsersForm_Exit";
            this.btn_UsersForm_Exit.Size = new System.Drawing.Size(331, 107);
            this.btn_UsersForm_Exit.TabIndex = 2;
            this.btn_UsersForm_Exit.Text = "EXIT\r\n\r\n";
            this.btn_UsersForm_Exit.UseVisualStyleBackColor = false;
            this.btn_UsersForm_Exit.Click += new System.EventHandler(this.btn_UsersForm_Exit_Click);
            // 
            // labelUsersListName
            // 
            this.labelUsersListName.AutoSize = true;
            this.labelUsersListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelUsersListName.Location = new System.Drawing.Point(58, 9);
            this.labelUsersListName.Name = "labelUsersListName";
            this.labelUsersListName.Size = new System.Drawing.Size(83, 28);
            this.labelUsersListName.TabIndex = 27;
            this.labelUsersListName.Text = "USERS:";
            // 
            // usersList
            // 
            this.usersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersList.FormattingEnabled = true;
            this.usersList.ItemHeight = 25;
            this.usersList.Location = new System.Drawing.Point(26, 40);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(459, 404);
            this.usersList.TabIndex = 28;
            this.usersList.SelectedIndexChanged += new System.EventHandler(this.usersList_SelectedIndexChanged);
            // 
            // labelEventLogListName
            // 
            this.labelEventLogListName.AutoSize = true;
            this.labelEventLogListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelEventLogListName.Location = new System.Drawing.Point(920, 24);
            this.labelEventLogListName.Name = "labelEventLogListName";
            this.labelEventLogListName.Size = new System.Drawing.Size(145, 28);
            this.labelEventLogListName.TabIndex = 29;
            this.labelEventLogListName.Text = "EVENT LOG:";
            // 
            // eventLogList
            // 
            this.eventLogList.BackColor = System.Drawing.Color.Gainsboro;
            this.eventLogList.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.eventLogList.FormattingEnabled = true;
            this.eventLogList.ItemHeight = 23;
            this.eventLogList.Location = new System.Drawing.Point(685, 84);
            this.eventLogList.Name = "eventLogList";
            this.eventLogList.Size = new System.Drawing.Size(618, 211);
            this.eventLogList.TabIndex = 30;
            this.eventLogList.SelectedIndexChanged += new System.EventHandler(this.eventLogList_SelectedIndexChanged);
            // 
            // btn_usersList_Add
            // 
            this.btn_usersList_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_usersList_Add.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_usersList_Add.Location = new System.Drawing.Point(662, 520);
            this.btn_usersList_Add.Name = "btn_usersList_Add";
            this.btn_usersList_Add.Size = new System.Drawing.Size(112, 99);
            this.btn_usersList_Add.TabIndex = 31;
            this.btn_usersList_Add.Text = "ADD";
            this.btn_usersList_Add.UseVisualStyleBackColor = false;
            this.btn_usersList_Add.Click += new System.EventHandler(this.btn_usersList_Add_Click);
            // 
            // btn_usersListRemake
            // 
            this.btn_usersListRemake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_usersListRemake.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_usersListRemake.Location = new System.Drawing.Point(870, 520);
            this.btn_usersListRemake.Name = "btn_usersListRemake";
            this.btn_usersListRemake.Size = new System.Drawing.Size(163, 99);
            this.btn_usersListRemake.TabIndex = 32;
            this.btn_usersListRemake.Text = "Remake";
            this.btn_usersListRemake.UseVisualStyleBackColor = false;
            this.btn_usersListRemake.Click += new System.EventHandler(this.btn_usersListRemake_Click);
            // 
            // btn_usersListDelete
            // 
            this.btn_usersListDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_usersListDelete.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_usersListDelete.Location = new System.Drawing.Point(1134, 520);
            this.btn_usersListDelete.Name = "btn_usersListDelete";
            this.btn_usersListDelete.Size = new System.Drawing.Size(135, 99);
            this.btn_usersListDelete.TabIndex = 33;
            this.btn_usersListDelete.Text = "Delete";
            this.btn_usersListDelete.UseVisualStyleBackColor = false;
            this.btn_usersListDelete.Click += new System.EventHandler(this.btn_usersListDelete_Click);
            // 
            // label_userListName
            // 
            this.label_userListName.AutoSize = true;
            this.label_userListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_userListName.Location = new System.Drawing.Point(662, 316);
            this.label_userListName.Name = "label_userListName";
            this.label_userListName.Size = new System.Drawing.Size(90, 28);
            this.label_userListName.TabIndex = 34;
            this.label_userListName.Text = "NAME:\r\n";
            // 
            // textBox_userList_Name
            // 
            this.textBox_userList_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_userList_Name.Location = new System.Drawing.Point(662, 360);
            this.textBox_userList_Name.Name = "textBox_userList_Name";
            this.textBox_userList_Name.Size = new System.Drawing.Size(155, 31);
            this.textBox_userList_Name.TabIndex = 35;
            // 
            // dateTimePicker_userListDateAge
            // 
            this.dateTimePicker_userListDateAge.CalendarFont = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_userListDateAge.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimePicker_userListDateAge.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker_userListDateAge.Location = new System.Drawing.Point(859, 360);
            this.dateTimePicker_userListDateAge.Name = "dateTimePicker_userListDateAge";
            this.dateTimePicker_userListDateAge.Size = new System.Drawing.Size(174, 31);
            this.dateTimePicker_userListDateAge.TabIndex = 36;
            // 
            // label_userListDate_age
            // 
            this.label_userListDate_age.AutoSize = true;
            this.label_userListDate_age.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_userListDate_age.Location = new System.Drawing.Point(859, 316);
            this.label_userListDate_age.Name = "label_userListDate_age";
            this.label_userListDate_age.Size = new System.Drawing.Size(132, 28);
            this.label_userListDate_age.TabIndex = 37;
            this.label_userListDate_age.Text = "BIRTHDAY:\r\n";
            // 
            // door1_userListForm
            // 
            this.door1_userListForm.BackColor = System.Drawing.Color.Transparent;
            this.door1_userListForm.Image = ((System.Drawing.Image)(resources.GetObject("door1_userListForm.Image")));
            this.door1_userListForm.Location = new System.Drawing.Point(339, 450);
            this.door1_userListForm.Name = "door1_userListForm";
            this.door1_userListForm.Size = new System.Drawing.Size(331, 274);
            this.door1_userListForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door1_userListForm.TabIndex = 38;
            this.door1_userListForm.TabStop = false;
            // 
            // checkBox_userList_student
            // 
            this.checkBox_userList_student.AutoSize = true;
            this.checkBox_userList_student.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.checkBox_userList_student.Location = new System.Drawing.Point(1090, 356);
            this.checkBox_userList_student.Name = "checkBox_userList_student";
            this.checkBox_userList_student.Size = new System.Drawing.Size(147, 35);
            this.checkBox_userList_student.TabIndex = 39;
            this.checkBox_userList_student.Text = "is Student";
            this.checkBox_userList_student.UseVisualStyleBackColor = true;
            // 
            // label_userList_student
            // 
            this.label_userList_student.AutoSize = true;
            this.label_userList_student.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_userList_student.Location = new System.Drawing.Point(1090, 316);
            this.label_userList_student.Name = "label_userList_student";
            this.label_userList_student.Size = new System.Drawing.Size(119, 28);
            this.label_userList_student.TabIndex = 40;
            this.label_userList_student.Text = "STUDENT:\r\n";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1348, 729);
            this.Controls.Add(this.label_userList_student);
            this.Controls.Add(this.checkBox_userList_student);
            this.Controls.Add(this.label_userListDate_age);
            this.Controls.Add(this.dateTimePicker_userListDateAge);
            this.Controls.Add(this.textBox_userList_Name);
            this.Controls.Add(this.label_userListName);
            this.Controls.Add(this.btn_usersListDelete);
            this.Controls.Add(this.btn_usersListRemake);
            this.Controls.Add(this.btn_usersList_Add);
            this.Controls.Add(this.eventLogList);
            this.Controls.Add(this.labelEventLogListName);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.labelUsersListName);
            this.Controls.Add(this.btn_UsersForm_Exit);
            this.Controls.Add(this.door1_userListForm);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.door1_userListForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UsersForm_Exit;
        private System.Windows.Forms.Label labelUsersListName;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Label labelEventLogListName;
        private System.Windows.Forms.ListBox eventLogList;
        private System.Windows.Forms.Button btn_usersList_Add;
        private System.Windows.Forms.Button btn_usersListRemake;
        private System.Windows.Forms.Button btn_usersListDelete;
        private System.Windows.Forms.Label label_userListName;
        private System.Windows.Forms.TextBox textBox_userList_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_userListDateAge;
        private System.Windows.Forms.Label label_userListDate_age;
        private System.Windows.Forms.PictureBox door1_userListForm;
        private System.Windows.Forms.CheckBox checkBox_userList_student;
        private System.Windows.Forms.Label label_userList_student;
    }
}