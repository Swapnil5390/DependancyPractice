using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyPractice
{
    public class Bussiness:IBussiness
    {
        IDataAccess obj = null;
        public Bussiness(IDataAccess dataAccess)
        { 
        obj=dataAccess;
        }
        public void SignUp(string username, string password)
        {
            //DataAccess obj = new DataAccess();
            //obj.SignUp(username, password);
            // IDataAccess obj = new DataAccessSql();
            //obj.SignUp(username, password);
            //  IDataAccess obj2 = new DataAccessSql();
            // obj2.SignUp(username, password);
            obj.SignUp(username, password);
        }
    }
}
        