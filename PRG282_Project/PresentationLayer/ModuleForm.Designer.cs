namespace PRG282_Project.PresentationLayer
{
    partial class ModuleForm
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
            label9 = new Label();
            ModuleView = new DataGridView();
            DeregisterButton = new Button();
            RegisterButton = new Button();
            StudentNumberBox = new MaskedTextBox();
            label1 = new Label();
            SearchButton = new Button();
            ModuleCodeBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ModuleView).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(194, 95);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 28;
            label9.Text = "Modules";
            // 
            // ModuleView
            // 
            ModuleView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModuleView.Location = new Point(63, 118);
            ModuleView.Name = "ModuleView";
            ModuleView.RowHeadersWidth = 51;
            ModuleView.RowTemplate.Height = 29;
            ModuleView.Size = new Size(327, 104);
            ModuleView.TabIndex = 27;
            // 
            // DeregisterButton
            // 
            DeregisterButton.Location = new Point(296, 240);
            DeregisterButton.Name = "DeregisterButton";
            DeregisterButton.Size = new Size(94, 29);
            DeregisterButton.TabIndex = 26;
            DeregisterButton.Text = "Deregister";
            DeregisterButton.UseVisualStyleBackColor = true;
            DeregisterButton.Click += DeregisterButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(184, 240);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(94, 29);
            RegisterButton.TabIndex = 25;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // StudentNumberBox
            // 
            StudentNumberBox.Location = new Point(175, 37);
            StudentNumberBox.Mask = "00000000";
            StudentNumberBox.Name = "StudentNumberBox";
            StudentNumberBox.Size = new Size(125, 27);
            StudentNumberBox.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 30;
            label1.Text = "Student Number";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(322, 36);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 31;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ModuleCodeBox
            // 
            ModuleCodeBox.Location = new Point(51, 241);
            ModuleCodeBox.Name = "ModuleCodeBox";
            ModuleCodeBox.Size = new Size(118, 27);
            ModuleCodeBox.TabIndex = 32;
            // 
            // ModuleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 312);
            Controls.Add(ModuleCodeBox);
            Controls.Add(SearchButton);
            Controls.Add(label1);
            Controls.Add(StudentNumberBox);
            Controls.Add(label9);
            Controls.Add(ModuleView);
            Controls.Add(DeregisterButton);
            Controls.Add(RegisterButton);
            Name = "ModuleForm";
            Text = "ModuleForm";
            ((System.ComponentModel.ISupportInitialize)ModuleView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView ModuleView;
        private Button DeregisterButton;
        private Button RegisterButton;
        private MaskedTextBox StudentNumberBox;
        private Label label1;
        private Button SearchButton;
        private TextBox ModuleCodeBox;
    }
}