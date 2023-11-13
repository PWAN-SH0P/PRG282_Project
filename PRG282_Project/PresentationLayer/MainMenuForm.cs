using System.Data;
using PRG282_Project.DataAccessLayer;
using PRG282_Project.LogicLayer;

namespace PRG282_Project
{
    public partial class MainMenuForm : Form
    {


        public MainMenuForm()
        {
            InitializeComponent();

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
            handler.Create(student);
            MessageBox.Show("Student added successfully.");

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }

        private void DeregisterButton_Click(object sender, EventArgs e)
        {

        }



        private void StudentNumberBox_Leave(object sender, EventArgs e)
        {

        }
    }
}