namespace Library
{
    partial class AdminForm
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
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxAdminName = new System.Windows.Forms.TextBox();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btn_MainFormClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonInput.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonInput.Location = new System.Drawing.Point(473, 195);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(239, 96);
            this.buttonInput.TabIndex = 0;
            this.buttonInput.Text = "INPUT";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxAdminName
            // 
            this.textBoxAdminName.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdminName.Location = new System.Drawing.Point(63, 92);
            this.textBoxAdminName.Multiline = true;
            this.textBoxAdminName.Name = "textBoxAdminName";
            this.textBoxAdminName.Size = new System.Drawing.Size(295, 86);
            this.textBoxAdminName.TabIndex = 1;
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdminPassword.Location = new System.Drawing.Point(63, 297);
            this.textBoxAdminPassword.Multiline = true;
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.Size = new System.Drawing.Size(295, 86);
            this.textBoxAdminPassword.TabIndex = 2;
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.Font = new System.Drawing.Font("Tempus Sans ITC", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelAdminName.Location = new System.Drawing.Point(73, 29);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(251, 42);
            this.labelAdminName.TabIndex = 3;
            this.labelAdminName.Text = "ADMIN NAME:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tempus Sans ITC", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(73, 224);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(201, 42);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "PASSWORD:";
            // 
            // btn_MainFormClose
            // 
            this.btn_MainFormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_MainFormClose.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_MainFormClose.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_MainFormClose.Location = new System.Drawing.Point(473, 387);
            this.btn_MainFormClose.Name = "btn_MainFormClose";
            this.btn_MainFormClose.Size = new System.Drawing.Size(239, 96);
            this.btn_MainFormClose.TabIndex = 5;
            this.btn_MainFormClose.Text = "EXIT\r\n";
            this.btn_MainFormClose.UseVisualStyleBackColor = false;
            this.btn_MainFormClose.Click += new System.EventHandler(this.btn_MainFormClose_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(779, 495);
            this.Controls.Add(this.btn_MainFormClose);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelAdminName);
            this.Controls.Add(this.textBoxAdminPassword);
            this.Controls.Add(this.textBoxAdminName);
            this.Controls.Add(this.buttonInput);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxAdminName;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btn_MainFormClose;
    }
}