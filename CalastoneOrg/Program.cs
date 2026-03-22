using System.Diagnostics;

namespace CalastoneOrg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserService UserService = new UserService();

            UserService.InformUser("Enter alert name:");
            string alertName = UserService.GetUserInput();
            UserService.InformUser("Enter alert description:");
            string alertDescription = UserService.GetUserInput();

            AlertService JaidAlert = new AlertService(alertName, alertDescription);
            Console.WriteLine($"Alert: {JaidAlert.Alert}");

            UserService.InformUser("Enter Operations agent name::");
            string operationsName = UserService.GetUserInput();
            UserService.InformUser("Enter Operations agent role:");
            string operationsRole = UserService.GetUserInput();

            Operations Godson = new Operations(operationsName, operationsRole);
            UserService.InformUser($"{Godson.Work()}");
            UserService.InformUser("InformClient()");
            UserService.InformUser("EscalateAlert()");

            UserService.InformUser("Enter developer name:");
            string developerName = UserService.GetUserInput();
            UserService.InformUser("Enter developer role:");
            string developerRole = UserService.GetUserInput();

            Developer Sam = new Developer(developerName, developerRole);
            UserService.InformUser($"{Sam.Work()}");
            UserService.InformUser($"{Sam.ResolveAlert()}");
        }
    }
}