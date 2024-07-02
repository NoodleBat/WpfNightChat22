using WpfLibrary2NNC;
using System.ServiceModel;

namespace WpfLibrary2NNC
{
    internal class ServerUser
    {
        public int ID { get; set; }

        public string Name {get; set;}

        public OperationContext operationContext { get; set; }
    }
}
