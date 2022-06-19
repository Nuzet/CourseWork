namespace Library
{
    partial class bookRentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookRentListForm));
            this.button_bookRentListFormExit = new System.Windows.Forms.Button();
            this.booksList = new System.Windows.Forms.ListBox();
            this.labelRentalListName = new System.Windows.Forms.Label();
            this.usersList = new System.Windows.Forms.ListBox();
            this.label_rental_ListName = new System.Windows.Forms.Label();
            this.eventLogList = new System.Windows.Forms.ListBox();
            this.labelEventLogListName = new System.Windows.Forms.Label();
            this.door1_rentalListForm = new System.Windows.Forms.PictureBox();
            this.button_rent = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.door1_rentalListForm)).BeginInit();
            this.SuspendLayout();
            // 
            // button_bookRentListFormExit
            // 
            this.button_bookRentListFormExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_bookRentListFormExit.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_bookRentListFormExit.Location = new System.Drawing.Point(623, 42);
            this.button_bookRentListFormExit.Name = "button_bookRentListFormExit";
            this.button_bookRentListFormExit.Size = new System.Drawing.Size(331, 111);
            this.button_bookRentListFormExit.TabIndex = 1;
            this.button_bookRentListFormExit.Text = "EXIT\r\n\r\n";
            this.button_bookRentListFormExit.UseVisualStyleBackColor = false;
            this.button_bookRentListFormExit.Click += new System.EventHandler(this.button_bookRentListFormExit_Click);
            // 
            // booksList
            // 
            this.booksList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksList.FormattingEnabled = true;
            this.booksList.ItemHeight = 25;
            this.booksList.Location = new System.Drawing.Point(34, 65);
            this.booksList.Name = "booksList";
            this.booksList.Size = new System.Drawing.Size(463, 404);
            this.booksList.TabIndex = 3;
            // 
            // labelRentalListName
            // 
            this.labelRentalListName.AutoSize = true;
            this.labelRentalListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelRentalListName.Location = new System.Drawing.Point(46, 31);
            this.labelRentalListName.Name = "labelRentalListName";
            this.labelRentalListName.Size = new System.Drawing.Size(93, 28);
            this.labelRentalListName.TabIndex = 27;
            this.labelRentalListName.Text = "BOOKS:";
            // 
            // usersList
            // 
            this.usersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersList.FormattingEnabled = true;
            this.usersList.ItemHeight = 25;
            this.usersList.Location = new System.Drawing.Point(1084, 65);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(459, 404);
            this.usersList.TabIndex = 29;
            // 
            // label_rental_ListName
            // 
            this.label_rental_ListName.AutoSize = true;
            this.label_rental_ListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_rental_ListName.Location = new System.Drawing.Point(1084, 31);
            this.label_rental_ListName.Name = "label_rental_ListName";
            this.label_rental_ListName.Size = new System.Drawing.Size(83, 28);
            this.label_rental_ListName.TabIndex = 30;
            this.label_rental_ListName.Text = "USERS:";
            // 
            // eventLogList
            // 
            this.eventLogList.BackColor = System.Drawing.Color.Gainsboro;
            this.eventLogList.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.eventLogList.FormattingEnabled = true;
            this.eventLogList.ItemHeight = 23;
            this.eventLogList.Location = new System.Drawing.Point(430, 541);
            this.eventLogList.Name = "eventLogList";
            this.eventLogList.Size = new System.Drawing.Size(737, 211);
            this.eventLogList.TabIndex = 31;
            // 
            // labelEventLogListName
            // 
            this.labelEventLogListName.AutoSize = true;
            this.labelEventLogListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelEventLogListName.Location = new System.Drawing.Point(499, 510);
            this.labelEventLogListName.Name = "labelEventLogListName";
            this.labelEventLogListName.Size = new System.Drawing.Size(145, 28);
            this.labelEventLogListName.TabIndex = 32;
            this.labelEventLogListName.Text = "EVENT LOG:";
            // 
            // door1_rentalListForm
            // 
            this.door1_rentalListForm.BackColor = System.Drawing.Color.Transparent;
            this.door1_rentalListForm.Image = ((System.Drawing.Image)(resources.GetObject("door1_rentalListForm.Image")));
            this.door1_rentalListForm.Location = new System.Drawing.Point(623, 185);
            this.door1_rentalListForm.Name = "door1_rentalListForm";
            this.door1_rentalListForm.Size = new System.Drawing.Size(331, 274);
            this.door1_rentalListForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door1_rentalListForm.TabIndex = 39;
            this.door1_rentalListForm.TabStop = false;
            // 
            // button_rent
            // 
            this.button_rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_rent.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_rent.Location = new System.Drawing.Point(34, 597);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(331, 111);
            this.button_rent.TabIndex = 40;
            this.button_rent.Text = "RENT";
            this.button_rent.UseVisualStyleBackColor = false;
            this.button_rent.Click += new System.EventHandler(this.button_rent_Click);
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_return.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_return.Location = new System.Drawing.Point(1212, 597);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(331, 111);
            this.button_return.TabIndex = 41;
            this.button_return.Text = "RETURN";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // bookRentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1586, 764);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.labelEventLogListName);
            this.Controls.Add(this.eventLogList);
            this.Controls.Add(this.label_rental_ListName);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.labelRentalListName);
            this.Controls.Add(this.booksList);
            this.Controls.Add(this.button_bookRentListFormExit);
            this.Controls.Add(this.door1_rentalListForm);
            this.Name = "bookRentListForm";
            this.Text = "bookRentListForm";
            this.Load += new System.EventHandler(this.bookRentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.door1_rentalListForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_bookRentListFormExit;
        private System.Windows.Forms.ListBox booksList;
        private System.Windows.Forms.Label labelRentalListName;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Label label_rental_ListName;
        private System.Windows.Forms.ListBox eventLogList;
        private System.Windows.Forms.Label labelEventLogListName;
        private System.Windows.Forms.PictureBox door1_rentalListForm;
        private System.Windows.Forms.Button button_rent;
        private System.Windows.Forms.Button button_return;
    }
}