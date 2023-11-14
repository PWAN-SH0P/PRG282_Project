namespace PRG282_Project.PresentationLayer
{
    partial class DisplayForm
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
            StudentView = new DataGridView();
            SearchButton = new Button();
            ViewAllButton = new Button();
            StudentNumberBox = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)StudentView).BeginInit();
            SuspendLayout();
            // 
            // StudentView
            // 
            StudentView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentView.Location = new Point(25, 29);
            StudentView.Name = "StudentView";
            StudentView.RowHeadersWidth = 51;
            StudentView.RowTemplate.Height = 29;
            StudentView.Size = new Size(785, 289);
            StudentView.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(217, 371);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ViewAllButton
            // 
            ViewAllButton.Location = new Point(498, 371);
            ViewAllButton.Name = "ViewAllButton";
            ViewAllButton.Size = new Size(94, 29);
            ViewAllButton.TabIndex = 2;
            ViewAllButton.Text = "View All";
            ViewAllButton.UseVisualStyleBackColor = true;
            ViewAllButton.Click += ViewAllButton_Click;
            // 
            // StudentNumberBox
            // 
            StudentNumberBox.Location = new Point(327, 372);
            StudentNumberBox.Mask = "00000000";
            StudentNumberBox.Name = "StudentNumberBox";
            StudentNumberBox.Size = new Size(133, 27);
            StudentNumberBox.TabIndex = 3;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 484);
            Controls.Add(StudentNumberBox);
            Controls.Add(ViewAllButton);
            Controls.Add(SearchButton);
            Controls.Add(StudentView);
            Name = "DisplayForm";
            Text = "DisplayForm";
            ((System.ComponentModel.ISupportInitialize)StudentView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentView;
        private Button SearchButton;
        private Button ViewAllButton;
        private MaskedTextBox StudentNumberBox;
    }
}