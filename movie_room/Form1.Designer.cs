namespace movie_room
{
    partial class Form1
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            userBox = new TextBox();
            password_box = new TextBox();
            loginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(326, 119);
            label1.Name = "label1";
            label1.Size = new Size(160, 37);
            label1.TabIndex = 1;
            label1.Text = "Faça login!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 452);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // userBox
            // 
            userBox.Location = new Point(326, 188);
            userBox.Name = "userBox";
            userBox.Size = new Size(160, 23);
            userBox.TabIndex = 2;
            
            // 
            // password_box
            // 
            password_box.Location = new Point(326, 248);
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.Size = new Size(160, 23);
            password_box.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(326, 302);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(85, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "Entrar";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(password_box);
            Controls.Add(userBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox userBox;
        private TextBox password_box;
        private Button loginButton;
    }
}
