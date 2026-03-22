using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalastoneOrg
{
    public interface IOperations
    {
        string Alert { get; }
        string AlertDescription { get; }
        bool AlertResolved { get; set; }

        void InformClient();
        void EscalateAlert();

    }
}
