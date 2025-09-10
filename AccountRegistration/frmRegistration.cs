using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{



    public partial class frmRegistration : Form

        // 7. In the frmRegistration, create variables for string, int, and long data types. 
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        




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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click_1(object sender, EventArgs e)
        {

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
