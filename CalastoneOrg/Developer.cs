using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalastoneOrg
{
    public class Developer : IEmployee, IDeveloper
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public string Alert { get; private set; }
        public string AlertDescription { get; private set; }
        public bool AlertResolved { get; set; }
        public Developer(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public string Work()
        {
            return ($"{Name} is working as a {Role}.");
        }

        public string WriteCode()
        {
            return ($"{Name} is writing code.");
        }

        public bool ResolveAlert()
        {
            Console.WriteLine($"{Name} is resolving the alert: {AlertDescription}");
            AlertResolved = true;
            return AlertResolved;
        }

    }
}
