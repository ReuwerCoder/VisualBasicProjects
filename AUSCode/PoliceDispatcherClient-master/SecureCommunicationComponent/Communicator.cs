using System;
using System.Reflection;
using System.Security.Permissions;

[assembly: AssemblyKeyFile(@"..\..\..\E237CLOGAN.snk")]
namespace SecureCommunicationComponent
{

    //[assembly: AssemblyVersionAttribute("1.0.0000.0")]

    public class Communicator
    {
        private const string Recv = "Received:";

        public string SendAlert(string addressee, string message)
        {
            AssemblyName assemName = Assembly.GetExecutingAssembly().GetName();

            string version = assemName.Version.ToString();

            string alert = String.Concat(Recv, " ", version, " ", message, " ", addressee);
            return alert;
        }
    }
}

