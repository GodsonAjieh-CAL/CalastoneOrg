using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalastoneOrg
{
    public class AlertService
    {
        public string Alert { get; private set; }
        public string AlertDescription { get; private set; }
        public AlertService(string alert, string alertDescription) 
        {
            Alert = alert;
            AlertDescription = alertDescription;
        }

    }
}
