namespace Library
{
    partial class SecondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondForm));
            this.button_SecondForm_Exit = new System.Windows.Forms.Button();
            this.door1SecondForm = new System.Windows.Forms.PictureBox();
            this.button_open_bookRentListForm = new System.Windows.Forms.Button();
            this.pictureBoxBookRent = new System.Windows.Forms.PictureBox();
            this.button_thingRentalListOpen = new System.Windows.Forms.Button();
            this.pictureBoxThingRentList = new System.Windows.Forms.PictureBox();
            this.buttonReview = new System.Windows.Forms.Button();
            this.Review = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door1SecondForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThingRentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Review)).BeginInit();
            this.SuspendLayout();
            // 
            // button_SecondForm_Exit
            // 
            this.button_SecondForm_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_SecondForm_Exit.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_SecondForm_Exit.Location = new System.Drawing.Point(612, 140);
            this.button_SecondForm_Exit.Name = "button_SecondForm_Exit";
            this.button_SecondForm_Exit.Size = new System.Drawing.Size(331, 111);
            this.button_SecondForm_Exit.TabIndex = 1;
            this.button_SecondForm_Exit.Text = "EXIT\r\n\r\n";
            this.button_SecondForm_Exit.UseVisualStyleBackColor = false;
            this.button_SecondForm_Exit.Click += new System.EventHandler(this.button_SecondForm_Exit_Click);
            // 
            // door1SecondForm
            // 
            this.door1SecondForm.BackColor = System.Drawing.Color.Transparent;
            this.door1SecondForm.Image = ((System.Drawing.Image)(resources.GetObject("door1SecondForm.Image")));
            this.door1SecondForm.Location = new System.Drawing.Point(612, 257);
            this.door1SecondForm.Name = "door1SecondForm";
            this.door1SecondForm.Size = new System.Drawing.Size(331, 274);
            this.door1SecondForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door1SecondForm.TabIndex = 12;
            this.door1SecondForm.TabStop = false;
            // 
            // button_open_bookRentListForm
            // 
            this.button_open_bookRentListForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_open_bookRentListForm.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_open_bookRentListForm.Location = new System.Drawing.Point(212, 41);
            this.button_open_bookRentListForm.Name = "button_open_bookRentListForm";
            this.button_open_bookRentListForm.Size = new System.Drawing.Size(331, 137);
            this.button_open_bookRentListForm.TabIndex = 13;
            this.button_open_bookRentListForm.Text = "BOOK RENTAL";
            this.button_open_bookRentListForm.UseVisualStyleBackColor = false;
            this.button_open_bookRentListForm.Click += new System.EventHandler(this.button_open_bookRentListForm_Click);
            // 
            // pictureBoxBookRent
            // 
            this.pictureBoxBookRent.Image = global::Library.Properties.Resources.download_removebg_preview__2_;
            this.pictureBoxBookRent.Location = new System.Drawing.Point(34, 1);
            this.pictureBoxBookRent.Name = "pictureBoxBookRent";
            this.pictureBoxBookRent.Size = new System.Drawing.Size(170, 177);
            this.pictureBoxBookRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBookRent.TabIndex = 14;
            this.pictureBoxBookRent.TabStop = false;
            // 
            // button_thingRentalListOpen
            // 
            this.button_thingRentalListOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_thingRentalListOpen.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_thingRentalListOpen.Location = new System.Drawing.Point(212, 226);
            this.button_thingRentalListOpen.Name = "button_thingRentalListOpen";
            this.button_thingRentalListOpen.Size = new System.Drawing.Size(331, 137);
            this.button_thingRentalListOpen.TabIndex = 17;
            this.button_thingRentalListOpen.Text = "THING RENTAL";
            this.button_thingRentalListOpen.UseVisualStyleBackColor = false;
            this.button_thingRentalListOpen.Click += new System.EventHandler(this.button_thingRentalListOpen_Click);
            // 
            // pictureBoxThingRentList
            // 
            this.pictureBoxThingRentList.Image = global::Library.Properties.Resources.Rental_03_Preview_removebg_preview;
            this.pictureBoxThingRentList.Location = new System.Drawing.Point(12, 184);
            this.pictureBoxThingRentList.Name = "pictureBoxThingRentList";
            this.pictureBoxThingRentList.Size = new System.Drawing.Size(192, 189);
            this.pictureBoxThingRentList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxThingRentList.TabIndex = 18;
            this.pictureBoxThingRentList.TabStop = false;
            // 
            // buttonReview
            // 
            this.buttonReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonReview.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonReview.Location = new System.Drawing.Point(212, 448);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(331, 117);
            this.buttonReview.TabIndex = 19;
            this.buttonReview.Text = "REVIEW";
            this.buttonReview.UseVisualStyleBackColor = false;
            this.buttonReview.Click += new System.EventHandler(this.buttonReview_Click);
            // 
            // Review
            // 
            this.Review.Image = global::Library.Properties.Resources.download_removebg_preview__3_;
            this.Review.Location = new System.Drawing.Point(36, 426);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(170, 139);
            this.Review.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Review.TabIndex = 20;
            this.Review.TabStop = false;
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(986, 627);
            this.Controls.Add(this.Review);
            this.Controls.Add(this.buttonReview);
            this.Controls.Add(this.pictureBoxThingRentList);
            this.Controls.Add(this.button_thingRentalListOpen);
            this.Controls.Add(this.pictureBoxBookRent);
            this.Controls.Add(this.button_open_bookRentListForm);
            this.Controls.Add(this.door1SecondForm);
            this.Controls.Add(this.button_SecondForm_Exit);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.Load += new System.EventHandler(this.SecondForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.door1SecondForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThingRentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Review)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SecondForm_Exit;
        private System.Windows.Forms.PictureBox door1SecondForm;
        private System.Windows.Forms.Button button_open_bookRentListForm;
        private System.Windows.Forms.PictureBox pictureBoxBookRent;
        private System.Windows.Forms.Button button_thingRentalListOpen;
        private System.Windows.Forms.PictureBox pictureBoxThingRentList;
        private System.Windows.Forms.Button buttonReview;
        private System.Windows.Forms.PictureBox Review;
    }
}