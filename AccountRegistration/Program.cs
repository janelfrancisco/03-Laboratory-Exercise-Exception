using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    internal static class Program
    {

        // 4. Create a class named StudentInformationClass with the following static variables
        class StudentInformationClass
        {
            public int SetStudentNo = 0;
            public int SetContactNo = 0;
            public string SetProgram = " ";
            public string SetGender = " ";
            public string SetBirthday = " ";
            public string SetFullName = " ";
            














        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRegistration());
        }
    }
}
