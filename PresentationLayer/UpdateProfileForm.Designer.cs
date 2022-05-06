
namespace PresentationLayer
    {
    partial class UpdateProfileForm
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
            this.GoBackButton = new System.Windows.Forms.Button();
            this.EnterNewUsernameLabel = new System.Windows.Forms.Label();
            this.EnterNewPasswordLabel = new System.Windows.Forms.Label();
            this.NewUsernameTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.updateProfileButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(56, 29);
            this.GoBackButton.TabIndex = 0;
            this.GoBackButton.Text = "Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // EnterNewUsernameLabel
            // 
            this.EnterNewUsernameLabel.AutoSize = true;
            this.EnterNewUsernameLabel.Location = new System.Drawing.Point(18, 97);
            this.EnterNewUsernameLabel.Name = "EnterNewUsernameLabel";
            this.EnterNewUsernameLabel.Size = new System.Drawing.Size(145, 20);
            this.EnterNewUsernameLabel.TabIndex = 1;
            this.EnterNewUsernameLabel.Text = "Enter new username:";
            // 
            // EnterNewPasswordLabel
            // 
            this.EnterNewPasswordLabel.AutoSize = true;
            this.EnterNewPasswordLabel.Location = new System.Drawing.Point(18, 172);
            this.EnterNewPasswordLabel.Name = "EnterNewPasswordLabel";
            this.EnterNewPasswordLabel.Size = new System.Drawing.Size(144, 20);
            this.EnterNewPasswordLabel.TabIndex = 2;
            this.EnterNewPasswordLabel.Text = "Enter new password:";
            // 
            // NewUsernameTextBox
            // 
            this.NewUsernameTextBox.Location = new System.Drawing.Point(194, 94);
            this.NewUsernameTextBox.Name = "NewUsernameTextBox";
            this.NewUsernameTextBox.Size = new System.Drawing.Size(205, 27);
            this.NewUsernameTextBox.TabIndex = 3;
            this.NewUsernameTextBox.TextChanged += new System.EventHandler(this.NewUsernameTextBox_TextChanged);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(194, 169);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(205, 27);
            this.NewPasswordTextBox.TabIndex = 4;
            this.NewPasswordTextBox.TextChanged += new System.EventHandler(this.NewPasswordTextBox_TextChanged);
            // 
            // updateProfileButton
            // 
            this.updateProfileButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateProfileButton.Location = new System.Drawing.Point(223, 232);
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.Size = new System.Drawing.Size(137, 37);
            this.updateProfileButton.TabIndex = 5;
            this.updateProfileButton.Text = "Update Profile";
            this.updateProfileButton.UseVisualStyleBackColor = true;
            this.updateProfileButton.Click += new System.EventHandler(this.updateProfileButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(256, 12);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 20);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username";
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 331);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.updateProfileButton);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.NewUsernameTextBox);
            this.Controls.Add(this.EnterNewPasswordLabel);
            this.Controls.Add(this.EnterNewUsernameLabel);
            this.Controls.Add(this.GoBackButton);
            this.Name = "UpdateProfileForm";
            this.Text = "Update Profile";
            this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label EnterNewUsernameLabel;
        private System.Windows.Forms.Label EnterNewPasswordLabel;
        private System.Windows.Forms.TextBox NewUsernameTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Button updateProfileButton;
        private System.Windows.Forms.Label UsernameLabel;
        }
    }