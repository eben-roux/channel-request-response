using System;
using Shuttle.Esb;
using Shuttle.RequestResponse.Messages;

namespace Shuttle.RequestResponse.Client
{
    public class MemberRegisteredHandler : IMessageHandler<MemberRegisteredEvent>
    {
        public void ProcessMessage(IHandlerContext<MemberRegisteredEvent> context)
        {
            Console.WriteLine($"[MEMBER REGISTERED] : username = '{context.Message.UserName}'");
        }
    }
}