
using Microsoft.Extensions.DependencyInjection;
namespace DependancyPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<IDataAccess,DataAccessNosql>();
             services.AddSingleton<IDataAccess, DataAccessSql>();
            services.AddSingleton<IDataAccess, Redis>();
            services.AddSingleton<IBussiness, Bussiness>();
            services.AddSingleton<IBussiness, Bussiness2>();
            services.AddSingleton<UserInterface>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            
            UserInterface ui=serviceProvider.GetService<UserInterface>();

            ui.getData();


            //  Console.WriteLine("Hello, World!");
            //  IDataAccess dataAccessNosql =new DataAccessNosql();
            //  IDataAccess sql =new DataAccessSql();
            //  IDataAccess redis = new Redis();
            //IBussiness obj = new Bussiness(redis);//
            //  IBussiness obj2 = new Bussiness2(sql);

            //  UserInterface userInterface = new UserInterface(obj2);
            //  userInterface.getData();
        }
    }
}
