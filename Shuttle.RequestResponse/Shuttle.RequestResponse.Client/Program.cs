using System;
using Castle.Windsor;
using Shuttle.Core.Castle;
using Shuttle.Esb;
using Shuttle.RequestResponse.Messages;

namespace Shuttle.RequestResponse.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorComponentContainer(new WindsorContainer());

            ServiceBus.Register(container);

            using (var bus = ServiceBus.Create(container).Start())
            {
                string userName;

                while (!string.IsNullOrEmpty(userName = Console.ReadLine()))
                {
                    bus.Send(new RegisterMemberCommand
                    {
                        UserName = userName
                    });
                }
            }
        }
    }
}
