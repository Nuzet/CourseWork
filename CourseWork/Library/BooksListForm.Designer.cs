namespace Library
{
    partial class BooksListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksListForm));
            this.btn_BooksListForm_Exit = new System.Windows.Forms.Button();
            this.booksList = new System.Windows.Forms.ListBox();
            this.mainBooksList = new System.Windows.Forms.ListBox();
            this.btn_maidBookList_Add = new System.Windows.Forms.Button();
            this.textBox_mainBookListName = new System.Windows.Forms.TextBox();
            this.label_Name_mainBookList = new System.Windows.Forms.Label();
            this.btn_mainBookListRemake = new System.Windows.Forms.Button();
            this.door1_BookListForm = new System.Windows.Forms.PictureBox();
            this.btn_mainBokkList_delete = new System.Windows.Forms.Button();
            this.btn_bookList_Add = new System.Windows.Forms.Button();
            this.btn_bookListRemake = new System.Windows.Forms.Button();
            this.btn_bookListDelete = new System.Windows.Forms.Button();
            this.textBox_booksList_Name = new System.Windows.Forms.TextBox();
            this.labelBooksListName = new System.Windows.Forms.Label();
            this.textBoxBooksListAuthor = new System.Windows.Forms.TextBox();
            this.label_booksListAuthor = new System.Windows.Forms.Label();
            this.labelBooksListPages = new System.Windows.Forms.Label();
            this.textBoxBooksListPages = new System.Windows.Forms.TextBox();
            this.labelBooksListLanguage = new System.Windows.Forms.Label();
            this.textBoxBooksListLanguage = new System.Windows.Forms.TextBox();
            this.dateTimePickerBooksListDate = new System.Windows.Forms.DateTimePicker();
            this.labelBooksListDate = new System.Windows.Forms.Label();
            this.eventLogList = new System.Windows.Forms.ListBox();
            this.labelBooklistName = new System.Windows.Forms.Label();
            this.labelmainBooksListName = new System.Windows.Forms.Label();
            this.labelEventLogListName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.door1_BookListForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BooksListForm_Exit
            // 
            this.btn_BooksListForm_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_BooksListForm_Exit.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_BooksListForm_Exit.Location = new System.Drawing.Point(761, 100);
            this.btn_BooksListForm_Exit.Name = "btn_BooksListForm_Exit";
            this.btn_BooksListForm_Exit.Size = new System.Drawing.Size(331, 107);
            this.btn_BooksListForm_Exit.TabIndex = 1;
            this.btn_BooksListForm_Exit.Text = "EXIT\r\n\r\n";
            this.btn_BooksListForm_Exit.UseVisualStyleBackColor = false;
            this.btn_BooksListForm_Exit.Click += new System.EventHandler(this.btn_BooksListForm_Exit_Click);
            // 
            // booksList
            // 
            this.booksList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksList.FormattingEnabled = true;
            this.booksList.ItemHeight = 25;
            this.booksList.Location = new System.Drawing.Point(93, 60);
            this.booksList.Name = "booksList";
            this.booksList.Size = new System.Drawing.Size(459, 404);
            this.booksList.TabIndex = 2;
            this.booksList.SelectedIndexChanged += new System.EventHandler(this.booksList_SelectedIndexChanged);
            // 
            // mainBooksList
            // 
            this.mainBooksList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainBooksList.FormattingEnabled = true;
            this.mainBooksList.ItemHeight = 25;
            this.mainBooksList.Location = new System.Drawing.Point(1300, 60);
            this.mainBooksList.Name = "mainBooksList";
            this.mainBooksList.Size = new System.Drawing.Size(459, 404);
            this.mainBooksList.TabIndex = 3;
            this.mainBooksList.SelectedIndexChanged += new System.EventHandler(this.mainBooksList_SelectedIndexChanged);
            // 
            // btn_maidBookList_Add
            // 
            this.btn_maidBookList_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_maidBookList_Add.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_maidBookList_Add.Location = new System.Drawing.Point(1288, 574);
            this.btn_maidBookList_Add.Name = "btn_maidBookList_Add";
            this.btn_maidBookList_Add.Size = new System.Drawing.Size(112, 99);
            this.btn_maidBookList_Add.TabIndex = 5;
            this.btn_maidBookList_Add.Text = "ADD";
            this.btn_maidBookList_Add.UseVisualStyleBackColor = false;
            this.btn_maidBookList_Add.Click += new System.EventHandler(this.btn_maidBookList_Add_Click);
            // 
            // textBox_mainBookListName
            // 
            this.textBox_mainBookListName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_mainBookListName.Location = new System.Drawing.Point(1300, 516);
            this.textBox_mainBookListName.Name = "textBox_mainBookListName";
            this.textBox_mainBookListName.Size = new System.Drawing.Size(155, 31);
            this.textBox_mainBookListName.TabIndex = 7;
            // 
            // label_Name_mainBookList
            // 
            this.label_Name_mainBookList.AutoSize = true;
            this.label_Name_mainBookList.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_Name_mainBookList.Location = new System.Drawing.Point(1300, 482);
            this.label_Name_mainBookList.Name = "label_Name_mainBookList";
            this.label_Name_mainBookList.Size = new System.Drawing.Size(90, 28);
            this.label_Name_mainBookList.TabIndex = 8;
            this.label_Name_mainBookList.Text = "NAME:\r\n";
            // 
            // btn_mainBookListRemake
            // 
            this.btn_mainBookListRemake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_mainBookListRemake.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_mainBookListRemake.Location = new System.Drawing.Point(1462, 574);
            this.btn_mainBookListRemake.Name = "btn_mainBookListRemake";
            this.btn_mainBookListRemake.Size = new System.Drawing.Size(163, 99);
            this.btn_mainBookListRemake.TabIndex = 9;
            this.btn_mainBookListRemake.Text = "Remake";
            this.btn_mainBookListRemake.UseVisualStyleBackColor = false;
            this.btn_mainBookListRemake.Click += new System.EventHandler(this.btn_mainBookListRemake_Click);
            // 
            // door1_BookListForm
            // 
            this.door1_BookListForm.BackColor = System.Drawing.Color.Transparent;
            this.door1_BookListForm.Image = ((System.Drawing.Image)(resources.GetObject("door1_BookListForm.Image")));
            this.door1_BookListForm.Location = new System.Drawing.Point(761, 213);
            this.door1_BookListForm.Name = "door1_BookListForm";
            this.door1_BookListForm.Size = new System.Drawing.Size(331, 274);
            this.door1_BookListForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door1_BookListForm.TabIndex = 10;
            this.door1_BookListForm.TabStop = false;
            // 
            // btn_mainBokkList_delete
            // 
            this.btn_mainBokkList_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_mainBokkList_delete.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_mainBokkList_delete.Location = new System.Drawing.Point(1665, 574);
            this.btn_mainBokkList_delete.Name = "btn_mainBokkList_delete";
            this.btn_mainBokkList_delete.Size = new System.Drawing.Size(135, 99);
            this.btn_mainBokkList_delete.TabIndex = 11;
            this.btn_mainBokkList_delete.Text = "Delete";
            this.btn_mainBokkList_delete.UseVisualStyleBackColor = false;
            this.btn_mainBokkList_delete.Click += new System.EventHandler(this.btn_mainBokkList_delete_Click);
            // 
            // btn_bookList_Add
            // 
            this.btn_bookList_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_bookList_Add.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_bookList_Add.Location = new System.Drawing.Point(30, 699);
            this.btn_bookList_Add.Name = "btn_bookList_Add";
            this.btn_bookList_Add.Size = new System.Drawing.Size(112, 99);
            this.btn_bookList_Add.TabIndex = 12;
            this.btn_bookList_Add.Text = "ADD";
            this.btn_bookList_Add.UseVisualStyleBackColor = false;
            this.btn_bookList_Add.Click += new System.EventHandler(this.btn_bookList_Add_Click);
            // 
            // btn_bookListRemake
            // 
            this.btn_bookListRemake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_bookListRemake.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_bookListRemake.Location = new System.Drawing.Point(194, 699);
            this.btn_bookListRemake.Name = "btn_bookListRemake";
            this.btn_bookListRemake.Size = new System.Drawing.Size(163, 99);
            this.btn_bookListRemake.TabIndex = 13;
            this.btn_bookListRemake.Text = "Remake";
            this.btn_bookListRemake.UseVisualStyleBackColor = false;
            this.btn_bookListRemake.Click += new System.EventHandler(this.btn_bookListRemake_Click);
            // 
            // btn_bookListDelete
            // 
            this.btn_bookListDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_bookListDelete.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_bookListDelete.Location = new System.Drawing.Point(417, 699);
            this.btn_bookListDelete.Name = "btn_bookListDelete";
            this.btn_bookListDelete.Size = new System.Drawing.Size(135, 99);
            this.btn_bookListDelete.TabIndex = 14;
            this.btn_bookListDelete.Text = "Delete";
            this.btn_bookListDelete.UseVisualStyleBackColor = false;
            this.btn_bookListDelete.Click += new System.EventHandler(this.btn_bookListDelete_Click);
            // 
            // textBox_booksList_Name
            // 
            this.textBox_booksList_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_booksList_Name.Location = new System.Drawing.Point(30, 516);
            this.textBox_booksList_Name.Name = "textBox_booksList_Name";
            this.textBox_booksList_Name.Size = new System.Drawing.Size(155, 31);
            this.textBox_booksList_Name.TabIndex = 15;
            // 
            // labelBooksListName
            // 
            this.labelBooksListName.AutoSize = true;
            this.labelBooksListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelBooksListName.Location = new System.Drawing.Point(30, 482);
            this.labelBooksListName.Name = "labelBooksListName";
            this.labelBooksListName.Size = new System.Drawing.Size(90, 28);
            this.labelBooksListName.TabIndex = 16;
            this.labelBooksListName.Text = "NAME:\r\n";
            // 
            // textBoxBooksListAuthor
            // 
            this.textBoxBooksListAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxBooksListAuthor.Location = new System.Drawing.Point(31, 612);
            this.textBoxBooksListAuthor.Name = "textBoxBooksListAuthor";
            this.textBoxBooksListAuthor.Size = new System.Drawing.Size(155, 31);
            this.textBoxBooksListAuthor.TabIndex = 17;
            // 
            // label_booksListAuthor
            // 
            this.label_booksListAuthor.AutoSize = true;
            this.label_booksListAuthor.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_booksListAuthor.Location = new System.Drawing.Point(31, 581);
            this.label_booksListAuthor.Name = "label_booksListAuthor";
            this.label_booksListAuthor.Size = new System.Drawing.Size(117, 28);
            this.label_booksListAuthor.TabIndex = 18;
            this.label_booksListAuthor.Text = "AUTHOR:\r\n";
            // 
            // labelBooksListPages
            // 
            this.labelBooksListPages.AutoSize = true;
            this.labelBooksListPages.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelBooksListPages.Location = new System.Drawing.Point(209, 482);
            this.labelBooksListPages.Name = "labelBooksListPages";
            this.labelBooksListPages.Size = new System.Drawing.Size(89, 28);
            this.labelBooksListPages.TabIndex = 19;
            this.labelBooksListPages.Text = "PAGES:";
            // 
            // textBoxBooksListPages
            // 
            this.textBoxBooksListPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxBooksListPages.Location = new System.Drawing.Point(209, 516);
            this.textBoxBooksListPages.Name = "textBoxBooksListPages";
            this.textBoxBooksListPages.Size = new System.Drawing.Size(155, 31);
            this.textBoxBooksListPages.TabIndex = 20;
            // 
            // labelBooksListLanguage
            // 
            this.labelBooksListLanguage.AutoSize = true;
            this.labelBooksListLanguage.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelBooksListLanguage.Location = new System.Drawing.Point(209, 581);
            this.labelBooksListLanguage.Name = "labelBooksListLanguage";
            this.labelBooksListLanguage.Size = new System.Drawing.Size(148, 28);
            this.labelBooksListLanguage.TabIndex = 21;
            this.labelBooksListLanguage.Text = "LANGUAGE:";
            // 
            // textBoxBooksListLanguage
            // 
            this.textBoxBooksListLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxBooksListLanguage.Location = new System.Drawing.Point(209, 612);
            this.textBoxBooksListLanguage.Name = "textBoxBooksListLanguage";
            this.textBoxBooksListLanguage.Size = new System.Drawing.Size(155, 31);
            this.textBoxBooksListLanguage.TabIndex = 22;
            // 
            // dateTimePickerBooksListDate
            // 
            this.dateTimePickerBooksListDate.CalendarFont = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBooksListDate.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimePickerBooksListDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePickerBooksListDate.Location = new System.Drawing.Point(393, 552);
            this.dateTimePickerBooksListDate.Name = "dateTimePickerBooksListDate";
            this.dateTimePickerBooksListDate.Size = new System.Drawing.Size(174, 31);
            this.dateTimePickerBooksListDate.TabIndex = 23;
            // 
            // labelBooksListDate
            // 
            this.labelBooksListDate.AutoSize = true;
            this.labelBooksListDate.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelBooksListDate.Location = new System.Drawing.Point(393, 516);
            this.labelBooksListDate.Name = "labelBooksListDate";
            this.labelBooksListDate.Size = new System.Drawing.Size(78, 28);
            this.labelBooksListDate.TabIndex = 24;
            this.labelBooksListDate.Text = "DATE:";
            // 
            // eventLogList
            // 
            this.eventLogList.BackColor = System.Drawing.Color.Gainsboro;
            this.eventLogList.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.eventLogList.FormattingEnabled = true;
            this.eventLogList.ItemHeight = 23;
            this.eventLogList.Location = new System.Drawing.Point(676, 699);
            this.eventLogList.Name = "eventLogList";
            this.eventLogList.Size = new System.Drawing.Size(618, 165);
            this.eventLogList.TabIndex = 25;
            this.eventLogList.SelectedIndexChanged += new System.EventHandler(this.eventLogList_SelectedIndexChanged);
            // 
            // labelBooklistName
            // 
            this.labelBooklistName.AutoSize = true;
            this.labelBooklistName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelBooklistName.Location = new System.Drawing.Point(93, 29);
            this.labelBooklistName.Name = "labelBooklistName";
            this.labelBooklistName.Size = new System.Drawing.Size(93, 28);
            this.labelBooklistName.TabIndex = 26;
            this.labelBooklistName.Text = "BOOKS:";
            // 
            // labelmainBooksListName
            // 
            this.labelmainBooksListName.AutoSize = true;
            this.labelmainBooksListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelmainBooksListName.Location = new System.Drawing.Point(1300, 29);
            this.labelmainBooksListName.Name = "labelmainBooksListName";
            this.labelmainBooksListName.Size = new System.Drawing.Size(173, 28);
            this.labelmainBooksListName.TabIndex = 27;
            this.labelmainBooksListName.Text = " MAIN BOOKS:";
            // 
            // labelEventLogListName
            // 
            this.labelEventLogListName.AutoSize = true;
            this.labelEventLogListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelEventLogListName.Location = new System.Drawing.Point(676, 645);
            this.labelEventLogListName.Name = "labelEventLogListName";
            this.labelEventLogListName.Size = new System.Drawing.Size(145, 28);
            this.labelEventLogListName.TabIndex = 28;
            this.labelEventLogListName.Text = "EVENT LOG:";
            // 
            // BooksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1924, 875);
            this.Controls.Add(this.labelEventLogListName);
            this.Controls.Add(this.labelmainBooksListName);
            this.Controls.Add(this.labelBooklistName);
            this.Controls.Add(this.eventLogList);
            this.Controls.Add(this.labelBooksListDate);
            this.Controls.Add(this.dateTimePickerBooksListDate);
            this.Controls.Add(this.textBoxBooksListLanguage);
            this.Controls.Add(this.labelBooksListLanguage);
            this.Controls.Add(this.textBoxBooksListPages);
            this.Controls.Add(this.labelBooksListPages);
            this.Controls.Add(this.label_booksListAuthor);
            this.Controls.Add(this.textBoxBooksListAuthor);
            this.Controls.Add(this.labelBooksListName);
            this.Controls.Add(this.textBox_booksList_Name);
            this.Controls.Add(this.btn_bookListDelete);
            this.Controls.Add(this.btn_bookListRemake);
            this.Controls.Add(this.btn_bookList_Add);
            this.Controls.Add(this.btn_mainBokkList_delete);
            this.Controls.Add(this.door1_BookListForm);
            this.Controls.Add(this.btn_mainBookListRemake);
            this.Controls.Add(this.label_Name_mainBookList);
            this.Controls.Add(this.textBox_mainBookListName);
            this.Controls.Add(this.btn_maidBookList_Add);
            this.Controls.Add(this.mainBooksList);
            this.Controls.Add(this.booksList);
            this.Controls.Add(this.btn_BooksListForm_Exit);
            this.Name = "BooksListForm";
            this.Text = "BooksListForm";
            this.Load += new System.EventHandler(this.BooksListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.door1_BookListForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BooksListForm_Exit;
        private System.Windows.Forms.ListBox booksList;
        private System.Windows.Forms.ListBox mainBooksList;
        private System.Windows.Forms.Button btn_maidBookList_Add;
        private System.Windows.Forms.TextBox textBox_mainBookListName;
        private System.Windows.Forms.Label label_Name_mainBookList;
        private System.Windows.Forms.Button btn_mainBookListRemake;
        private System.Windows.Forms.PictureBox door1_BookListForm;
        private System.Windows.Forms.Button btn_mainBokkList_delete;
        private System.Windows.Forms.Button btn_bookList_Add;
        private System.Windows.Forms.Button btn_bookListRemake;
        private System.Windows.Forms.Button btn_bookListDelete;
        private System.Windows.Forms.TextBox textBox_booksList_Name;
        private System.Windows.Forms.Label labelBooksListName;
        private System.Windows.Forms.TextBox textBoxBooksListAuthor;
        private System.Windows.Forms.Label label_booksListAuthor;
        private System.Windows.Forms.Label labelBooksListPages;
        private System.Windows.Forms.TextBox textBoxBooksListPages;
        private System.Windows.Forms.Label labelBooksListLanguage;
        private System.Windows.Forms.TextBox textBoxBooksListLanguage;
        private System.Windows.Forms.DateTimePicker dateTimePickerBooksListDate;
        private System.Windows.Forms.Label labelBooksListDate;
        private System.Windows.Forms.ListBox eventLogList;
        private System.Windows.Forms.Label labelBooklistName;
        private System.Windows.Forms.Label labelmainBooksListName;
        private System.Windows.Forms.Label labelEventLogListName;
    }
}