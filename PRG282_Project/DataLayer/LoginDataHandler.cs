using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.DataLayer
{
    internal class LoginDataHandler
    {
        public bool IsExistingUser(string username)
        {
            LoginFileHandler handler = new LoginFileHandler();
            List<string> userList = new List<string>();

            bool userExists;

            if (userList.Contains(username))
            {
                userExists = true;
            }
            else
            {
                userExists = false;
            }
            return userExists;
        }

        public bool IsValidCredentials(string username, string password)
        {
            LoginFileHandler handler = new LoginFileHandler();
            List<string> credentialList = new List<string>();

            bool credentialsValid;
            string searchTerm = $"{username},{password}";

            if (credentialList.Contains(searchTerm))
            {
                credentialsValid = true;
            }
            else
            {
                credentialsValid = false;
            }
            return credentialsValid;
        }
    
        public void AddUser(string username, string password)
        {
            LoginFileHandler handler = new LoginFileHandler();
            handler.Write(username, password);
        }
    }
}
