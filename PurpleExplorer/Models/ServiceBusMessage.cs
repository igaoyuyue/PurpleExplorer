using System.Collections.Generic;

namespace PurpleExplorer.Models
{
    public class ServiceBusMessage
    {
        public string Content { get; set; }
        public IDictionary<string, string> Properties { get; set; }
    }
}