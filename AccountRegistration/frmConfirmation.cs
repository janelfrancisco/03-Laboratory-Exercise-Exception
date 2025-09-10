using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AccountRegistration.frmRegistration;

namespace AccountRegistration
{
    public partial class frmConfirmation: Form
    {
        
        //for text
       // private StudentInfoClass.DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Student information submitted successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

        //for numbers
        //private StudentInfoClass.DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public frmConfirmation()
        {
            InitializeComponent();
            /*
            DelProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new StudentInfoClass.DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new StudentInfoClass.DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new StudentInfoClass.DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new StudentInfoClass.DelegateText(StudentInfoClass.GetAddress);


            DelNumAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo); */
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            /*
            lblStudentNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblName.Text = DelLastName(StudentInfoClass.LastName);
            lblAge.Text = DelFirstName(StudentInfoClass.FirstName);
            lblBirthday.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblGender.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
            */
        }


        
    }
}
