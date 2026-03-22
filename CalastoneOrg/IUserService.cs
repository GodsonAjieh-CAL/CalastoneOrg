using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalastoneOrg
{
    public interface IUserService
    {
        string GetUserInput();
        void InformUser(string message);
    }

    public class UserService : IUserService
    {
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public void InformUser(string message)
        {
            Console.WriteLine(message);
        }
    }
}
