using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalastoneOrg
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Role { get; set; }

        string Work();

    }
}
