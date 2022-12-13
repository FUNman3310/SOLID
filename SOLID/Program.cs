using SRP;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "HuseynHabib12";
            string password = "Anakonda89";

            User user = new User();
            UserChecker checker = new UserChecker();

            if (checker.CheckUsername(username))
            {
                user.Username = username;
            }

            if (checker.CheckPassword(password))
            {
                user.Password = password;
            }

            UserCRUD userCRUD = new UserCRUD();

            userCRUD.Create(user);
            userCRUD.Create(new User { Username = "AmandaShow", Password = "kukushka02" });

            userCRUD.Delite(user);

            foreach (User item in Database.UserDataBase)
            {
                Console.WriteLine(item.Username +" "+item.Password);
            }
        }
    }
}