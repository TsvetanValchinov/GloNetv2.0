
namespace PresentationLayer
    {
    partial class SeeOtherUserProfileForm
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
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.postsLabel = new System.Windows.Forms.Label();
            this.SeeAllPostsButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.Location = new System.Drawing.Point(21, 23);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(109, 23);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search users:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.Location = new System.Drawing.Point(136, 25);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(226, 25);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.Text = "write username to search here...";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(385, 25);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOutButton.Location = new System.Drawing.Point(676, 25);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(99, 29);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.Location = new System.Drawing.Point(21, 53);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(765, 32);
            this.HorizontalLine.TabIndex = 10;
            this.HorizontalLine.Text = "_________________________________________________________________________________" +
    "_____________________________________________";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(354, 97);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(73, 20);
            this.UsernameLabel.TabIndex = 11;
            this.UsernameLabel.Text = "username";
            // 
            // postsLabel
            // 
            this.postsLabel.AutoSize = true;
            this.postsLabel.Location = new System.Drawing.Point(43, 174);
            this.postsLabel.Name = "postsLabel";
            this.postsLabel.Size = new System.Drawing.Size(45, 20);
            this.postsLabel.TabIndex = 12;
            this.postsLabel.Text = "Posts:";
            // 
            // SeeAllPostsButton
            // 
            this.SeeAllPostsButton.Location = new System.Drawing.Point(253, 170);
            this.SeeAllPostsButton.Name = "SeeAllPostsButton";
            this.SeeAllPostsButton.Size = new System.Drawing.Size(109, 29);
            this.SeeAllPostsButton.TabIndex = 13;
            this.SeeAllPostsButton.Text = "See all posts";
            this.SeeAllPostsButton.UseVisualStyleBackColor = true;
            this.SeeAllPostsButton.Click += new System.EventHandler(this.SeeAllPostsButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(43, 88);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(50, 29);
            this.GoBackButton.TabIndex = 14;
            this.GoBackButton.Text = "Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // SeeOtherUserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.SeeAllPostsButton);
            this.Controls.Add(this.postsLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.HorizontalLine);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Name = "SeeOtherUserProfileForm";
            this.Text = "GloNet";
            this.Load += new System.EventHandler(this.SeeOtherUserProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label HorizontalLine;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label postsLabel;
        private System.Windows.Forms.Button SeeAllPostsButton;
        private System.Windows.Forms.Button GoBackButton;
        }
    }