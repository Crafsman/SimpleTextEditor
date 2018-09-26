using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    public struct UserInformationStruct
    {
        public string userName, password, userType, firstName, lastName, dateOfBirth;

    }


    public class FormsController
    {
       private LoginForm loginForm; 

       public FormsController()
        {
            loginForm = new LoginForm();
            loginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            loginForm.Show();

            //loginForm.c
        }
    }
}
