using System.Data;
using System.Windows.Forms;
using PRG282_Project.DataAccessLayer;
using PRG282_Project.LogicLayer;
using PRG282_Project.PresentationLayer;

namespace PRG282_Project
{
    public partial class MainMenuForm : Form
    {


        public MainMenuForm()
        {
            InitializeComponent();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(this);
        }

        private Student GetStudent()
        {
            int studentNumber = int.Parse(StudentNumberBox.Text);
            string firstName = FirstNameBox.Text;
            string surname = SurnameBox.Text;
            Image picture = PictureBox.Image;
            DateTime dateOfBirth = DateOfBirth.Value;
            int gender = GenderListBox.SelectedIndex;
            string phone = PhoneBox.Text;
            string streetAddress = StreetAddressBox.Text;

            Student student = new Student(studentNumber, firstName, surname, picture, dateOfBirth, gender, phone, streetAddress);

            return student;
        }

        private void ClearFormContents()
        {
            StudentNumberBox.Text = string.Empty;
            FirstNameBox.Text = string.Empty;
            SurnameBox.Text = string.Empty;
            PictureBox.Image = null;
            DateOfBirth.Value = DateTime.Now;
            GenderListBox.SelectedIndex = 0;
            PhoneBox.Text = string.Empty;
            StreetAddressBox.Text = string.Empty;
        }

        private DataTable GetModules(int studentNumber)
        {
            ModuleDataHandler handler = new ModuleDataHandler();
            DataTable table = handler.FetchModules(studentNumber);
            return table;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StudentDataAccessHandler handler = new StudentDataAccessHandler();

            Student student = GetStudent();
            int studentNumber = student.StudentNumber;

            bool IsExistingStudent = handler.Search(studentNumber).Rows.Count > 0;

            if (IsExistingStudent)
            {
                handler.Update(student);
                MessageBox.Show("This student has already been added to the database.");
                return;
            }

            handler.Create(student);
            MessageBox.Show("Student added successfully.");

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayForm displayForm = new DisplayForm();
            displayForm.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            StudentDataAccessHandler handler = new StudentDataAccessHandler();

            Student student = GetStudent();
            int studentNumber = student.StudentNumber;

            bool IsExistingStudent = handler.Search(studentNumber).Rows.Count > 0;

            if (IsExistingStudent)
            {
                handler.Update(student);
                MessageBox.Show("Student updated successfully.");
            }

        }


   

        private void AttachButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select an Image File";
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff|All Files|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.FileName;
                    PictureBox.Image = Image.FromFile(path);
                }
            }
        }

        private void UpdateModulesButton_Click(object sender, EventArgs e)
        {
            ModuleForm form = new ModuleForm();
            form.Show();
        }
    }
}