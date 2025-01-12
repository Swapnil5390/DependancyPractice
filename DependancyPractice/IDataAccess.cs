using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyPractice
{
    public interface IDataAccess
    {
         public void SignUp(String Username, string PassWord);
    }
}
