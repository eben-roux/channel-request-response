using System;
using Shuttle.Core.ServiceHost;

namespace Shuttle.RequestResponse.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost.Run<Host>();
        }
    }
}
