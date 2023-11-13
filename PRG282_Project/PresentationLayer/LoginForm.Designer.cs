namespace PRG282_Project.PresentationLayer
{
    partial class LoginForm
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
            UserNameBox = new TextBox();
            PassWordBox = new TextBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // UserNameBox
            // 
            UserNameBox.Location = new Point(79, 77);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(125, 27);
            UserNameBox.TabIndex = 0;
            // 
            // PassWordBox
            // 
            PassWordBox.Location = new Point(241, 77);
            PassWordBox.Name = "PassWordBox";
            PassWordBox.PasswordChar = '*';
            PassWordBox.Size = new Size(125, 27);
            PassWordBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(110, 122);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(241, 122);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(94, 29);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 203);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(PassWordBox);
            Controls.Add(UserNameBox);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameBox;
        private TextBox PassWordBox;
        private Button LoginButton;
        private Button RegisterButton;
    }
}