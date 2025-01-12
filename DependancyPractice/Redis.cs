using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyPractice
{
    public class Redis:IDataAccess
    {
        public void SignUp(string username, string password)
        {
            Console.WriteLine("Username" + username + "password" + password + "Added into database using redis");
        }
    }
}
