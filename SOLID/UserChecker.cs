using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UserChecker
    {
        public bool CheckUsername(string username)
        {
            if (String.IsNullOrWhiteSpace(username)||username.Length>20||username.Length<5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckPassword(string password)
        {
            if (String.IsNullOrWhiteSpace(password) || password.Length > 20 || password.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
