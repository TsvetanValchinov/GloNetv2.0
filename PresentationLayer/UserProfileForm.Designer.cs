
namespace PresentationLayer
    {
    partial class UserProfileForm
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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.postsLabel = new System.Windows.Forms.Label();
            this.SeeAllPostsButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateProfileButton = new System.Windows.Forms.Button();
            this.CreateNewPostButton = new System.Windows.Forms.Button();
            this.LastPostLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.VerticalLine = new System.Windows.Forms.Label();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.lastPostTitleLabel = new System.Windows.Forms.Label();
            this.LastPostContentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.Location = new System.Drawing.Point(23, 15);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(109, 23);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search users:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.Location = new System.Drawing.Point(138, 15);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(226, 25);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.Text = "write username to search here...";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOutButton.Location = new System.Drawing.Point(677, 13);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(99, 29);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.Location = new System.Drawing.Point(23, 41);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(765, 32);
            this.HorizontalLine.TabIndex = 3;
            this.HorizontalLine.Text = "_________________________________________________________________________________" +
    "_____________________________________________";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(364, 89);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(0, 20);
            this.UsernameLabel.TabIndex = 4;
            // 
            // postsLabel
            // 
            this.postsLabel.AutoSize = true;
            this.postsLabel.Location = new System.Drawing.Point(40, 166);
            this.postsLabel.Name = "postsLabel";
            this.postsLabel.Size = new System.Drawing.Size(45, 20);
            this.postsLabel.TabIndex = 5;
            this.postsLabel.Text = "Posts:";
            // 
            // SeeAllPostsButton
            // 
            this.SeeAllPostsButton.Location = new System.Drawing.Point(225, 162);
            this.SeeAllPostsButton.Name = "SeeAllPostsButton";
            this.SeeAllPostsButton.Size = new System.Drawing.Size(109, 29);
            this.SeeAllPostsButton.TabIndex = 6;
            this.SeeAllPostsButton.Text = "See all posts";
            this.SeeAllPostsButton.UseVisualStyleBackColor = true;
            this.SeeAllPostsButton.Click += new System.EventHandler(this.SeeAllPostsButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(380, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateProfileButton
            // 
            this.UpdateProfileButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateProfileButton.Location = new System.Drawing.Point(660, 89);
            this.UpdateProfileButton.Name = "UpdateProfileButton";
            this.UpdateProfileButton.Size = new System.Drawing.Size(116, 35);
            this.UpdateProfileButton.TabIndex = 8;
            this.UpdateProfileButton.Text = "Update Profile";
            this.UpdateProfileButton.UseVisualStyleBackColor = true;
            this.UpdateProfileButton.Click += new System.EventHandler(this.UpdateProfileButton_Click);
            // 
            // CreateNewPostButton
            // 
            this.CreateNewPostButton.Location = new System.Drawing.Point(380, 162);
            this.CreateNewPostButton.Name = "CreateNewPostButton";
            this.CreateNewPostButton.Size = new System.Drawing.Size(179, 29);
            this.CreateNewPostButton.TabIndex = 9;
            this.CreateNewPostButton.Text = "Create new post";
            this.CreateNewPostButton.UseVisualStyleBackColor = true;
            this.CreateNewPostButton.Click += new System.EventHandler(this.CreateNewPostButton_Click);
            // 
            // LastPostLabel
            // 
            this.LastPostLabel.AutoSize = true;
            this.LastPostLabel.Location = new System.Drawing.Point(40, 228);
            this.LastPostLabel.Name = "LastPostLabel";
            this.LastPostLabel.Size = new System.Drawing.Size(71, 20);
            this.LastPostLabel.TabIndex = 10;
            this.LastPostLabel.Text = "Last post:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(40, 273);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 20);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "Title:";
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(40, 317);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(64, 20);
            this.ContentLabel.TabIndex = 12;
            this.ContentLabel.Text = "Content:";
            // 
            // VerticalLine
            // 
            this.VerticalLine.AutoSize = true;
            this.VerticalLine.Location = new System.Drawing.Point(380, 222);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(13, 220);
            this.VerticalLine.TabIndex = 15;
            this.VerticalLine.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Location = new System.Drawing.Point(420, 228);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(83, 20);
            this.CommentsLabel.TabIndex = 16;
            this.CommentsLabel.Text = "Comments:";
            // 
            // lastPostTitleLabel
            // 
            this.lastPostTitleLabel.AutoSize = true;
            this.lastPostTitleLabel.Location = new System.Drawing.Point(110, 273);
            this.lastPostTitleLabel.Name = "lastPostTitleLabel";
            this.lastPostTitleLabel.Size = new System.Drawing.Size(0, 20);
            this.lastPostTitleLabel.TabIndex = 17;
            // 
            // LastPostContentLabel
            // 
            this.LastPostContentLabel.AutoSize = true;
            this.LastPostContentLabel.Location = new System.Drawing.Point(110, 317);
            this.LastPostContentLabel.MaximumSize = new System.Drawing.Size(269, 120);
            this.LastPostContentLabel.Name = "LastPostContentLabel";
            this.LastPostContentLabel.Size = new System.Drawing.Size(0, 20);
            this.LastPostContentLabel.TabIndex = 18;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 451);
            this.Controls.Add(this.LastPostContentLabel);
            this.Controls.Add(this.lastPostTitleLabel);
            this.Controls.Add(this.CommentsLabel);
            this.Controls.Add(this.VerticalLine);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LastPostLabel);
            this.Controls.Add(this.CreateNewPostButton);
            this.Controls.Add(this.UpdateProfileButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SeeAllPostsButton);
            this.Controls.Add(this.postsLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.HorizontalLine);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Name = "UserProfileForm";
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label HorizontalLine;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label postsLabel;
        private System.Windows.Forms.Button SeeAllPostsButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button UpdateProfileButton;
        private System.Windows.Forms.Button CreateNewPostButton;
        private System.Windows.Forms.Label LastPostLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label VerticalLine;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.Label lastPostTitleLabel;
        private System.Windows.Forms.Label LastPostContentLabel;
        }
    }