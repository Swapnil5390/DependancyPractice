using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyPractice
{
    public class Bussiness2 : IBussiness
    { IDataAccess dataAccess;
        public Bussiness2(IDataAccess xy) 
        {
        dataAccess = xy;
        }
        public void SignUp(string Username, string Password)
        {
           dataAccess.SignUp(Username, Password);
        }
    }
}
