using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.DataAccessLayer;

namespace PRG282_Project.PresentationLayer
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool IsValidInput = int.TryParse(StudentNumberBox.Text, out int studentNumber);

            if (!IsValidInput)
            {
                StudentNumberBox.Text = string.Empty;
                return;
            }

            StudentDataAccessHandler handler = new StudentDataAccessHandler();
            StudentView.DataSource = handler.Search(studentNumber);
            
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            StudentDataAccessHandler handler = new StudentDataAccessHandler();
            StudentView.DataSource = handler.Read();
        }
    }
}
