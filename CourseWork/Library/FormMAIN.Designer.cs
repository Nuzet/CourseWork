namespace Library
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_toSecondFormAdmin = new System.Windows.Forms.Button();
            this.btn_MainFormClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.door1 = new System.Windows.Forms.PictureBox();
            this.door2 = new System.Windows.Forms.PictureBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.door3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_toSecondFormAdmin
            // 
            this.btn_toSecondFormAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_toSecondFormAdmin.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_toSecondFormAdmin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_toSecondFormAdmin.Location = new System.Drawing.Point(387, 169);
            this.btn_toSecondFormAdmin.Name = "btn_toSecondFormAdmin";
            this.btn_toSecondFormAdmin.Size = new System.Drawing.Size(181, 61);
            this.btn_toSecondFormAdmin.TabIndex = 0;
            this.btn_toSecondFormAdmin.Text = "INPUT FOR ADMIN";
            this.btn_toSecondFormAdmin.UseVisualStyleBackColor = false;
            this.btn_toSecondFormAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_MainFormClose
            // 
            this.btn_MainFormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_MainFormClose.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_MainFormClose.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_MainFormClose.Location = new System.Drawing.Point(675, 169);
            this.btn_MainFormClose.Name = "btn_MainFormClose";
            this.btn_MainFormClose.Size = new System.Drawing.Size(150, 61);
            this.btn_MainFormClose.TabIndex = 1;
            this.btn_MainFormClose.Text = "EXIT\r\n";
            this.btn_MainFormClose.UseVisualStyleBackColor = false;
            this.btn_MainFormClose.Click += new System.EventHandler(this.btn_MainFormClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(311, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 94);
            this.label1.TabIndex = 2;
            this.label1.Text = "LIBRARY\r\n";
            // 
            // door1
            // 
            this.door1.BackColor = System.Drawing.Color.Transparent;
            this.door1.Image = ((System.Drawing.Image)(resources.GetObject("door1.Image")));
            this.door1.Location = new System.Drawing.Point(347, 236);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(261, 257);
            this.door1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door1.TabIndex = 3;
            this.door1.TabStop = false;
            // 
            // door2
            // 
            this.door2.BackColor = System.Drawing.Color.Transparent;
            this.door2.Image = ((System.Drawing.Image)(resources.GetObject("door2.Image")));
            this.door2.Location = new System.Drawing.Point(628, 236);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(257, 257);
            this.door2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door2.TabIndex = 4;
            this.door2.TabStop = false;
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonInput.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonInput.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonInput.Location = new System.Drawing.Point(105, 163);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(150, 61);
            this.buttonInput.TabIndex = 5;
            this.buttonInput.Text = "INPUT\r\n\r\n";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // door3
            // 
            this.door3.BackColor = System.Drawing.Color.Transparent;
            this.door3.Image = ((System.Drawing.Image)(resources.GetObject("door3.Image")));
            this.door3.Location = new System.Drawing.Point(48, 236);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(261, 257);
            this.door3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door3.TabIndex = 6;
            this.door3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(897, 517);
            this.Controls.Add(this.door3);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MainFormClose);
            this.Controls.Add(this.btn_toSecondFormAdmin);
            this.Controls.Add(this.door1);
            this.Controls.Add(this.door2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.door1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_toSecondFormAdmin;
        private System.Windows.Forms.Button btn_MainFormClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox door1;
        private System.Windows.Forms.PictureBox door2;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.PictureBox door3;
    }
}
