
namespace PresentationLayer
    {
    partial class CreatePostForm
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.CreatePostButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(248, 27);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(82, 20);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username: ";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(116, 137);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(80, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Enter title: ";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(248, 134);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(352, 27);
            this.TitleTextBox.TabIndex = 2;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(116, 198);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(104, 20);
            this.ContentLabel.TabIndex = 3;
            this.ContentLabel.Text = "Enter content: ";
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(248, 195);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(352, 27);
            this.ContentTextBox.TabIndex = 4;
            this.ContentTextBox.TextChanged += new System.EventHandler(this.ContentTextBox_TextChanged);
            // 
            // CreatePostButton
            // 
            this.CreatePostButton.Location = new System.Drawing.Point(327, 319);
            this.CreatePostButton.Name = "CreatePostButton";
            this.CreatePostButton.Size = new System.Drawing.Size(176, 45);
            this.CreatePostButton.TabIndex = 5;
            this.CreatePostButton.Text = "Create Post";
            this.CreatePostButton.UseVisualStyleBackColor = true;
            this.CreatePostButton.Click += new System.EventHandler(this.CreatePostButton_Click);
            // 
            // CreatePostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreatePostButton);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "CreatePostForm";
            this.Text = "Create Post";
            this.Load += new System.EventHandler(this.CreatePostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Button CreatePostButton;
        }
    }