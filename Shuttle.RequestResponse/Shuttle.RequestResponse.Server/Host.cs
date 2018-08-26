using Castle.Windsor;
using Shuttle.Core.Castle;
using Shuttle.Core.ServiceHost;
using Shuttle.Esb;

namespace Shuttle.RequestResponse.Server
{
    public class Host : IServiceHost
    {
        private IServiceBus _bus;

        public void Start()
        {
            var container = new WindsorComponentContainer(new WindsorContainer());

            ServiceBus.Register(container);

            _bus = ServiceBus.Create(container).Start();
        }

        public void Stop()
        {
            _bus.Dispose();
        }
    }
}