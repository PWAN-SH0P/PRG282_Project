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
    public partial class ModuleForm : Form
    {
        public ModuleForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            StudentDataAccessHandler studentDataAccessHandler = new StudentDataAccessHandler();
            ModuleDataHandler moduleDataHandler = new ModuleDataHandler();
            string moduleCode = ModuleCodeBox.Text;

            bool IsValidInput = int.TryParse(StudentNumberBox.Text, out int studentNumber);
            bool IsExistingModule  = moduleDataHandler.ModuleList().Contains(moduleCode);
            bool IsExistingStudent = studentDataAccessHandler.Search(studentNumber).Rows.Count > 0;
            
            if(IsValidInput && IsExistingModule && IsExistingStudent)
            {
                moduleDataHandler.AddModule(studentNumber, moduleCode);
            }

        }

        private void DeregisterButton_Click(object sender, EventArgs e)
        {
            StudentDataAccessHandler studentDataAccessHandler = new StudentDataAccessHandler();
            ModuleDataHandler moduleDataHandler = new ModuleDataHandler();
            string moduleCode = ModuleCodeBox.Text;

            bool IsValidInput = int.TryParse(StudentNumberBox.Text, out int studentNumber);
            bool IsExistingModule = moduleDataHandler.ModuleList().Contains(moduleCode);
            bool IsExistingStudent = studentDataAccessHandler.Search(studentNumber).Rows.Count > 0;

            if (IsValidInput && IsExistingModule && IsExistingStudent)
            {
                moduleDataHandler.RemoveModule(studentNumber, moduleCode);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            StudentDataAccessHandler studentDataAccessHandler = new StudentDataAccessHandler();
            ModuleDataHandler moduleDataHandler = new ModuleDataHandler();
            
            bool IsValidInput = int.TryParse(StudentNumberBox.Text, out int studentNumber);
            bool IsExistingStudent = studentDataAccessHandler.Search(studentNumber).Rows.Count > 0;

            if (IsValidInput && IsExistingStudent)
            {
                ModuleView.DataSource = moduleDataHandler.FetchModules(studentNumber);
            }
        }
    }
}
