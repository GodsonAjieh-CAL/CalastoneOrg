using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalastoneOrg
{
    public class Operations : IEmployee, IOperations
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public string Alert { get; private set; }
        public string AlertDescription { get; private set; }
        public bool AlertResolved { get; set; }

        public Operations(string name, string role)
        {
            Name = name;
            Role = role;
        }
        
        public string Work()
        {
            return ($"{Name} is working as a {Role}.");
        }

        public void InformClient()
        {
            Console.WriteLine($"{Name} is informing the client about the {Alert}");
        }
        public void EscalateAlert()
        {
            Console.WriteLine($"{Name} is escalating the alert: {AlertDescription}");
        }
    }
}