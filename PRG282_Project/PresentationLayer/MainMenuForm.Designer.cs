namespace PRG282_Project
{
    partial class MainMenuForm
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
            StudentNumberBox = new MaskedTextBox();
            FirstNameBox = new TextBox();
            SurnameBox = new TextBox();
            PictureBox = new PictureBox();
            DateOfBirth = new DateTimePicker();
            GenderListBox = new ListBox();
            PhoneBox = new MaskedTextBox();
            StreetAddressBox = new TextBox();
            AddButton = new Button();
            DisplayButton = new Button();
            UpdateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            AttachButton = new Button();
            UpdateModulesButton = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // StudentNumberBox
            // 
            StudentNumberBox.Location = new Point(60, 47);
            StudentNumberBox.Mask = "00000000";
            StudentNumberBox.Name = "StudentNumberBox";
            StudentNumberBox.Size = new Size(125, 27);
            StudentNumberBox.TabIndex = 0;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(60, 80);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(125, 27);
            FirstNameBox.TabIndex = 1;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(60, 113);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(125, 27);
            SurnameBox.TabIndex = 2;
            // 
            // PictureBox
            // 
            PictureBox.Location = new Point(60, 146);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(125, 62);
            PictureBox.TabIndex = 3;
            PictureBox.TabStop = false;
            // 
            // DateOfBirth
            // 
            DateOfBirth.CustomFormat = "";
            DateOfBirth.Format = DateTimePickerFormat.Short;
            DateOfBirth.Location = new Point(60, 214);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(125, 27);
            DateOfBirth.TabIndex = 4;
            // 
            // GenderListBox
            // 
            GenderListBox.FormattingEnabled = true;
            GenderListBox.ItemHeight = 20;
            GenderListBox.Items.AddRange(new object[] { "Female", "Male" });
            GenderListBox.Location = new Point(60, 247);
            GenderListBox.Name = "GenderListBox";
            GenderListBox.Size = new Size(125, 24);
            GenderListBox.TabIndex = 5;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(60, 277);
            PhoneBox.Mask = "(999) 000-0000";
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(125, 27);
            PhoneBox.TabIndex = 6;
            // 
            // StreetAddressBox
            // 
            StreetAddressBox.Location = new Point(60, 310);
            StreetAddressBox.Name = "StreetAddressBox";
            StreetAddressBox.Size = new Size(125, 27);
            StreetAddressBox.TabIndex = 7;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(19, 375);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(122, 29);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add Student";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += UpdateButton_Click;
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(549, 357);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(125, 49);
            DisplayButton.TabIndex = 9;
            DisplayButton.Text = "View Students";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(156, 375);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(148, 29);
            UpdateButton.TabIndex = 10;
            UpdateButton.Text = "Update Student";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 50);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 16;
            label1.Text = "Student Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 87);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 17;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 120);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 18;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 146);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 19;
            label4.Text = "Picture of Student";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 219);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 20;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 251);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 21;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 280);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 22;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 317);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 23;
            label8.Text = "Street Address";
            // 
            // AttachButton
            // 
            AttachButton.Location = new Point(209, 172);
            AttachButton.Name = "AttachButton";
            AttachButton.Size = new Size(80, 29);
            AttachButton.TabIndex = 25;
            AttachButton.Text = "Attach";
            AttachButton.UseVisualStyleBackColor = true;
            AttachButton.Click += AttachButton_Click;
            // 
            // UpdateModulesButton
            // 
            UpdateModulesButton.Location = new Point(706, 357);
            UpdateModulesButton.Name = "UpdateModulesButton";
            UpdateModulesButton.Size = new Size(125, 49);
            UpdateModulesButton.TabIndex = 26;
            UpdateModulesButton.Text = "Update Modules";
            UpdateModulesButton.UseVisualStyleBackColor = true;
            UpdateModulesButton.Click += UpdateModulesButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UpdateButton);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Location = new Point(23, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 429);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 469);
            Controls.Add(UpdateModulesButton);
            Controls.Add(AttachButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DisplayButton);
            Controls.Add(StreetAddressBox);
            Controls.Add(PhoneBox);
            Controls.Add(GenderListBox);
            Controls.Add(DateOfBirth);
            Controls.Add(PictureBox);
            Controls.Add(SurnameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(StudentNumberBox);
            Controls.Add(groupBox1);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox StudentNumberBox;
        private TextBox FirstNameBox;
        private TextBox SurnameBox;
        private PictureBox PictureBox;
        private DateTimePicker DateOfBirth;
        private ListBox GenderListBox;
        private MaskedTextBox PhoneBox;
        private TextBox StreetAddressBox;
        private Button AddButton;
        private Button DisplayButton;
        private Button UpdateButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button AttachButton;
        private Button UpdateModulesButton;
        private GroupBox groupBox1;
    }
}