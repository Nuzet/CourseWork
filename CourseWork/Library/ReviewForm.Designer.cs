namespace Library
{
    partial class ReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewForm));
            this.button_ReviewForm_Exit = new System.Windows.Forms.Button();
            this.usersList = new System.Windows.Forms.ListBox();
            this.labelUsersListName = new System.Windows.Forms.Label();
            this.eventLogList = new System.Windows.Forms.ListBox();
            this.labelEventLogListName = new System.Windows.Forms.Label();
            this.btn_review_Send = new System.Windows.Forms.Button();
            this.textBoxReview = new System.Windows.Forms.TextBox();
            this.labelReview = new System.Windows.Forms.Label();
            this.door1_ReviewForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door1_ReviewForm)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ReviewForm_Exit
            // 
            this.button_ReviewForm_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_ReviewForm_Exit.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_ReviewForm_Exit.Location = new System.Drawing.Point(754, 598);
            this.button_ReviewForm_Exit.Name = "button_ReviewForm_Exit";
            this.button_ReviewForm_Exit.Size = new System.Drawing.Size(331, 111);
            this.button_ReviewForm_Exit.TabIndex = 2;
            this.button_ReviewForm_Exit.Text = "EXIT\r\n\r\n";
            this.button_ReviewForm_Exit.UseVisualStyleBackColor = false;
            this.button_ReviewForm_Exit.Click += new System.EventHandler(this.button_ReviewForm_Exit_Click);
            // 
            // usersList
            // 
            this.usersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersList.FormattingEnabled = true;
            this.usersList.ItemHeight = 25;
            this.usersList.Location = new System.Drawing.Point(12, 72);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(452, 379);
            this.usersList.TabIndex = 29;
            // 
            // labelUsersListName
            // 
            this.labelUsersListName.AutoSize = true;
            this.labelUsersListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelUsersListName.Location = new System.Drawing.Point(12, 28);
            this.labelUsersListName.Name = "labelUsersListName";
            this.labelUsersListName.Size = new System.Drawing.Size(83, 28);
            this.labelUsersListName.TabIndex = 30;
            this.labelUsersListName.Text = "USERS:";
            // 
            // eventLogList
            // 
            this.eventLogList.BackColor = System.Drawing.Color.Gainsboro;
            this.eventLogList.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.eventLogList.FormattingEnabled = true;
            this.eventLogList.ItemHeight = 23;
            this.eventLogList.Location = new System.Drawing.Point(500, 72);
            this.eventLogList.Name = "eventLogList";
            this.eventLogList.Size = new System.Drawing.Size(618, 211);
            this.eventLogList.TabIndex = 31;
            // 
            // labelEventLogListName
            // 
            this.labelEventLogListName.AutoSize = true;
            this.labelEventLogListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelEventLogListName.Location = new System.Drawing.Point(500, 28);
            this.labelEventLogListName.Name = "labelEventLogListName";
            this.labelEventLogListName.Size = new System.Drawing.Size(145, 28);
            this.labelEventLogListName.TabIndex = 32;
            this.labelEventLogListName.Text = "EVENT LOG:";
            // 
            // btn_review_Send
            // 
            this.btn_review_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_review_Send.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_review_Send.Location = new System.Drawing.Point(532, 621);
            this.btn_review_Send.Name = "btn_review_Send";
            this.btn_review_Send.Size = new System.Drawing.Size(149, 99);
            this.btn_review_Send.TabIndex = 33;
            this.btn_review_Send.Text = "SEND";
            this.btn_review_Send.UseVisualStyleBackColor = false;
            this.btn_review_Send.Click += new System.EventHandler(this.btn_review_Send_Click);
            // 
            // textBoxReview
            // 
            this.textBoxReview.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxReview.Location = new System.Drawing.Point(12, 507);
            this.textBoxReview.Multiline = true;
            this.textBoxReview.Name = "textBoxReview";
            this.textBoxReview.Size = new System.Drawing.Size(499, 241);
            this.textBoxReview.TabIndex = 34;
            this.textBoxReview.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelReview
            // 
            this.labelReview.AutoSize = true;
            this.labelReview.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelReview.Location = new System.Drawing.Point(23, 476);
            this.labelReview.Name = "labelReview";
            this.labelReview.Size = new System.Drawing.Size(105, 28);
            this.labelReview.TabIndex = 35;
            this.labelReview.Text = "REVIEW:";
            // 
            // door1_ReviewForm
            // 
            this.door1_ReviewForm.BackColor = System.Drawing.Color.Transparent;
            this.door1_ReviewForm.Image = ((System.Drawing.Image)(resources.GetObject("door1_ReviewForm.Image")));
            this.door1_ReviewForm.Location = new System.Drawing.Point(754, 318);
            this.door1_ReviewForm.Name = "door1_ReviewForm";
            this.door1_ReviewForm.Size = new System.Drawing.Size(331, 274);
            this.door1_ReviewForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door1_ReviewForm.TabIndex = 39;
            this.door1_ReviewForm.TabStop = false;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1114, 779);
            this.Controls.Add(this.door1_ReviewForm);
            this.Controls.Add(this.labelReview);
            this.Controls.Add(this.textBoxReview);
            this.Controls.Add(this.btn_review_Send);
            this.Controls.Add(this.labelEventLogListName);
            this.Controls.Add(this.eventLogList);
            this.Controls.Add(this.labelUsersListName);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.button_ReviewForm_Exit);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.door1_ReviewForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ReviewForm_Exit;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Label labelUsersListName;
        private System.Windows.Forms.ListBox eventLogList;
        private System.Windows.Forms.Label labelEventLogListName;
        private System.Windows.Forms.Button btn_review_Send;
        private System.Windows.Forms.TextBox textBoxReview;
        private System.Windows.Forms.Label labelReview;
        private System.Windows.Forms.PictureBox door1_ReviewForm;
    }
}