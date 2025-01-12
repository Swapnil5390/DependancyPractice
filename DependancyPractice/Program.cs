namespace DependancyPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello, World!");
            IDataAccess dataAccessNosql =new DataAccessNosql();
            IDataAccess sql =new DataAccessSql();
            IDataAccess redis = new Redis();
          IBussiness obj = new Bussiness(redis);//
            IBussiness obj2 = new Bussiness2(sql);

            UserInterface userInterface = new UserInterface(obj2);
            userInterface.getData();
        }
    }
}
