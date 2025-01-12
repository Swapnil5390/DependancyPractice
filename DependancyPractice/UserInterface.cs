using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyPractice
{

    public class UserInterface
    {
        public string UserName { get; set; }
        public string Password { get; set; }

       private IBussiness obj= null;
         public UserInterface(IBussiness bussiness)
        {
        obj = bussiness;
        }
        public void getData()
        {
            Console.WriteLine("Please enter username :");
            UserName = Console.ReadLine();
            Console.WriteLine("Please enter password:");
            Password = Console.ReadLine();

            //    Bussiness obj = new Bussiness();
            //    obj.SignUp(UserName, Password);
            //    IBussiness obj = new Bussiness();
            obj.SignUp(UserName, Password);
        }
    }
}