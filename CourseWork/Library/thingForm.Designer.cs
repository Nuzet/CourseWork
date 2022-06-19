namespace Library
{
    partial class thingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thingForm));
            this.button_things_Exit = new System.Windows.Forms.Button();
            this.eventLogList = new System.Windows.Forms.ListBox();
            this.labelEventLogListName = new System.Windows.Forms.Label();
            this.btn_thingsList_Add = new System.Windows.Forms.Button();
            this.thingsList = new System.Windows.Forms.ListBox();
            this.labelThingsListName = new System.Windows.Forms.Label();
            this.btn_thingsListRemake = new System.Windows.Forms.Button();
            this.btn_thingsListDelete = new System.Windows.Forms.Button();
            this.textBox_thingList_Name = new System.Windows.Forms.TextBox();
            this.label_thingListName = new System.Windows.Forms.Label();
            this.textBox_thingList_Count = new System.Windows.Forms.TextBox();
            this.label_thingListDate_Count = new System.Windows.Forms.Label();
            this.door1_thingListForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door1_thingListForm)).BeginInit();
            this.SuspendLayout();
            // 
            // button_things_Exit
            // 
            this.button_things_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_things_Exit.Font = new System.Drawing.Font("Tempus Sans ITC", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_things_Exit.Location = new System.Drawing.Point(895, 335);
            this.button_things_Exit.Name = "button_things_Exit";
            this.button_things_Exit.Size = new System.Drawing.Size(331, 111);
            this.button_things_Exit.TabIndex = 1;
            this.button_things_Exit.Text = "EXIT\r\n\r\n";
            this.button_things_Exit.UseVisualStyleBackColor = false;
            this.button_things_Exit.Click += new System.EventHandler(this.button_things_Exit_Click);
            // 
            // eventLogList
            // 
            this.eventLogList.BackColor = System.Drawing.Color.Gainsboro;
            this.eventLogList.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.eventLogList.FormattingEnabled = true;
            this.eventLogList.ItemHeight = 23;
            this.eventLogList.Location = new System.Drawing.Point(765, 61);
            this.eventLogList.Name = "eventLogList";
            this.eventLogList.Size = new System.Drawing.Size(618, 211);
            this.eventLogList.TabIndex = 31;
            // 
            // labelEventLogListName
            // 
            this.labelEventLogListName.AutoSize = true;
            this.labelEventLogListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelEventLogListName.Location = new System.Drawing.Point(765, 30);
            this.labelEventLogListName.Name = "labelEventLogListName";
            this.labelEventLogListName.Size = new System.Drawing.Size(145, 28);
            this.labelEventLogListName.TabIndex = 32;
            this.labelEventLogListName.Text = "EVENT LOG:";
            // 
            // btn_thingsList_Add
            // 
            this.btn_thingsList_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_thingsList_Add.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_thingsList_Add.Location = new System.Drawing.Point(56, 623);
            this.btn_thingsList_Add.Name = "btn_thingsList_Add";
            this.btn_thingsList_Add.Size = new System.Drawing.Size(112, 99);
            this.btn_thingsList_Add.TabIndex = 33;
            this.btn_thingsList_Add.Text = "ADD";
            this.btn_thingsList_Add.UseVisualStyleBackColor = false;
            this.btn_thingsList_Add.Click += new System.EventHandler(this.btn_thingsList_Add_Click);
            // 
            // thingsList
            // 
            this.thingsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.thingsList.FormattingEnabled = true;
            this.thingsList.ItemHeight = 25;
            this.thingsList.Location = new System.Drawing.Point(22, 61);
            this.thingsList.Name = "thingsList";
            this.thingsList.Size = new System.Drawing.Size(459, 404);
            this.thingsList.TabIndex = 34;
            this.thingsList.SelectedIndexChanged += new System.EventHandler(this.thingsList_SelectedIndexChanged);
            // 
            // labelThingsListName
            // 
            this.labelThingsListName.AutoSize = true;
            this.labelThingsListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelThingsListName.Location = new System.Drawing.Point(22, 30);
            this.labelThingsListName.Name = "labelThingsListName";
            this.labelThingsListName.Size = new System.Drawing.Size(103, 28);
            this.labelThingsListName.TabIndex = 35;
            this.labelThingsListName.Text = "THINGS:";
            // 
            // btn_thingsListRemake
            // 
            this.btn_thingsListRemake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_thingsListRemake.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_thingsListRemake.Location = new System.Drawing.Point(235, 623);
            this.btn_thingsListRemake.Name = "btn_thingsListRemake";
            this.btn_thingsListRemake.Size = new System.Drawing.Size(163, 99);
            this.btn_thingsListRemake.TabIndex = 36;
            this.btn_thingsListRemake.Text = "Remake";
            this.btn_thingsListRemake.UseVisualStyleBackColor = false;
            this.btn_thingsListRemake.Click += new System.EventHandler(this.btn_thingsListRemake_Click);
            // 
            // btn_thingsListDelete
            // 
            this.btn_thingsListDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_thingsListDelete.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_thingsListDelete.Location = new System.Drawing.Point(469, 623);
            this.btn_thingsListDelete.Name = "btn_thingsListDelete";
            this.btn_thingsListDelete.Size = new System.Drawing.Size(135, 99);
            this.btn_thingsListDelete.TabIndex = 37;
            this.btn_thingsListDelete.Text = "Delete";
            this.btn_thingsListDelete.UseVisualStyleBackColor = false;
            this.btn_thingsListDelete.Click += new System.EventHandler(this.btn_thingsListDelete_Click);
            // 
            // textBox_thingList_Name
            // 
            this.textBox_thingList_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_thingList_Name.Location = new System.Drawing.Point(56, 539);
            this.textBox_thingList_Name.Name = "textBox_thingList_Name";
            this.textBox_thingList_Name.Size = new System.Drawing.Size(155, 31);
            this.textBox_thingList_Name.TabIndex = 38;
            // 
            // label_thingListName
            // 
            this.label_thingListName.AutoSize = true;
            this.label_thingListName.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_thingListName.Location = new System.Drawing.Point(56, 499);
            this.label_thingListName.Name = "label_thingListName";
            this.label_thingListName.Size = new System.Drawing.Size(90, 28);
            this.label_thingListName.TabIndex = 39;
            this.label_thingListName.Text = "NAME:\r\n";
            // 
            // textBox_thingList_Count
            // 
            this.textBox_thingList_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_thingList_Count.Location = new System.Drawing.Point(255, 539);
            this.textBox_thingList_Count.Name = "textBox_thingList_Count";
            this.textBox_thingList_Count.Size = new System.Drawing.Size(100, 31);
            this.textBox_thingList_Count.TabIndex = 40;
            // 
            // label_thingListDate_Count
            // 
            this.label_thingListDate_Count.AutoSize = true;
            this.label_thingListDate_Count.Font = new System.Drawing.Font("Tempus Sans ITC", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_thingListDate_Count.Location = new System.Drawing.Point(255, 499);
            this.label_thingListDate_Count.Name = "label_thingListDate_Count";
            this.label_thingListDate_Count.Size = new System.Drawing.Size(101, 28);
            this.label_thingListDate_Count.TabIndex = 41;
            this.label_thingListDate_Count.Text = "COUNT:\r\n";
            // 
            // door1_thingListForm
            // 
            this.door1_thingListForm.BackColor = System.Drawing.Color.Transparent;
            this.door1_thingListForm.Image = ((System.Drawing.Image)(resources.GetObject("door1_thingListForm.Image")));
            this.door1_thingListForm.Location = new System.Drawing.Point(895, 464);
            this.door1_thingListForm.Name = "door1_thingListForm";
            this.door1_thingListForm.Size = new System.Drawing.Size(331, 274);
            this.door1_thingListForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door1_thingListForm.TabIndex = 42;
            this.door1_thingListForm.TabStop = false;
            // 
            // thingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1395, 750);
            this.Controls.Add(this.door1_thingListForm);
            this.Controls.Add(this.label_thingListDate_Count);
            this.Controls.Add(this.textBox_thingList_Count);
            this.Controls.Add(this.label_thingListName);
            this.Controls.Add(this.textBox_thingList_Name);
            this.Controls.Add(this.btn_thingsListDelete);
            this.Controls.Add(this.btn_thingsListRemake);
            this.Controls.Add(this.labelThingsListName);
            this.Controls.Add(this.thingsList);
            this.Controls.Add(this.btn_thingsList_Add);
            this.Controls.Add(this.labelEventLogListName);
            this.Controls.Add(this.eventLogList);
            this.Controls.Add(this.button_things_Exit);
            this.Name = "thingForm";
            this.Text = "thingForm";
            this.Load += new System.EventHandler(this.thingListBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.door1_thingListForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_things_Exit;
        private System.Windows.Forms.ListBox eventLogList;
        private System.Windows.Forms.Label labelEventLogListName;
        private System.Windows.Forms.Button btn_thingsList_Add;
        private System.Windows.Forms.ListBox thingsList;
        private System.Windows.Forms.Label labelThingsListName;
        private System.Windows.Forms.Button btn_thingsListRemake;
        private System.Windows.Forms.Button btn_thingsListDelete;
        private System.Windows.Forms.TextBox textBox_thingList_Name;
        private System.Windows.Forms.Label label_thingListName;
        private System.Windows.Forms.TextBox textBox_thingList_Count;
        private System.Windows.Forms.Label label_thingListDate_Count;
        private System.Windows.Forms.PictureBox door1_thingListForm;
    }
}