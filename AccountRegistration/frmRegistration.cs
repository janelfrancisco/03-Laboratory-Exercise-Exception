using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{



    public partial class frmRegistration : Form




        
    {
        // 4. Create a class named StudentInformationClass with the following static variables
        /*class StudentInformationClass
        {
            public int SetStudentNo = 0;
            public int SetContactNo = 0;
            public int SetAge = 0;
            public string SetProgram = " ";
            public string SetGender = " ";
            public string SetBirthday = " ";
            public string SetFullName = " ";
        } */


        // 7. In the frmRegistration, create variables for string, int, and long data types. 
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;


        // 9. Copy the methods in 03 Laboratory Exercise 1 - Method.txt file and paste in the frmRegistration class. 
        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }





        /*          [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
              private static extern IntPtr CreateRoundRectRgn(
          int nLeftRect,        // x-coordinate of upper-left corner
          int nTopRect,         // y-coordinate of upper-left corner
          int nRightRect,       // x-coordinate of lower-right corner
          int nBottomRect,      // y-coordinate of lower-right corner
          int nWidthEllipse,    // height of ellipse
          int nHeightEllipse   // width of ellipse
      );
        */
        public frmRegistration()
        {
            InitializeComponent();


            /*
            this.FormBorderStyle = FormBorderStyle.None;   // Remove the border
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, this.Height, 20, 20));  // Set rounded corners
            */
        }


        /* public class StudentInfoClass

        {


            //Delegate
            public delegate string DelegateText(string txt);
            public delegate long DelegateNumber(long number);


            //Static variables
            public static string FirstName = "";
            public static string LastName = "";
            public static string MiddleName = "";
            public static string Address = "";
            public static string Program = "";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;



            // Static return-type methods

            public static string GetFirstName(string firstName) => firstName;
            public static string GetLastName(string lastName) => lastName;
            public static string GetMiddleName(string middleName) => middleName;
            public static string GetAddress(string address) => address;
            public static string GetProgram(string program) => program;
            public static long GetAge(long age) => age;
            public static long GetContactNo(long contactNo) => contactNo;
            public static long GetStudentNo(long studentNo) => studentNo;
        } */

        private void btn_Next_Click(object sender, EventArgs e)
        {

            


            

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // 8. Generate a Load event by clicking it twice in the form of frmRegistration. Then, add the following code
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                 "BS Information Technology",
                 "BS Computer Science",
                 "BS Information Systems",
                 "BS in Accountancy",
                 "BS in Hospitality Management",
                 "BS in Tourism Management"
        };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

            string[] ListOfGender = new string[] { 
                "Male",
                "Female"
            
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click_1(object sender, EventArgs e)

        {
            // 10. Double click the submit button to generate a click event. Then, add the following code:
            // Challenge Exercise
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = (int)StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = (int)ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Null Error: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow Error: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Index Error: " + ex.Message);
            }



           


            /* StudentInfoClass.StudentNo = long.Parse(txtStudentNo.Text);
             StudentInfoClass.Program = cbPrograms.Text;
             StudentInfoClass.LastName = txtLastName.Text;
             StudentInfoClass.FirstName = txtFirstName.Text;
             StudentInfoClass.MiddleName = txtMiddleInitial.Text;
             StudentInfoClass.Age = long.Parse(txtAge.Text);
             StudentInfoClass.ContactNo = long.Parse(tBx_ContactNum.Text);
            // StudentInfoClass.Address = rTBx_Address.Text;

             frmConfirmation Form2 = new frmConfirmation();
             Form2.Show();
             this.Hide(); */
        }

        private void tBx_MidName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBx_ContactNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tBx_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tBx_Program_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
