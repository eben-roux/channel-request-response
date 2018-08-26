using System;
using Shuttle.Esb;
using Shuttle.RequestResponse.Messages;

namespace Shuttle.RequestResponse.Server
{
    public class RegisterMemberHandler : IMessageHandler<RegisterMemberCommand>
    {
        public void ProcessMessage(IHandlerContext<RegisterMemberCommand> context)
        {
            Console.WriteLine($"[MEMBER REGISTRATION REQUESTED]: username = '{context.Message.UserName}'");

            context.Send(new MemberRegisteredEvent
            {
                UserName = context.Message.UserName
            }, c => c.Reply());
        }
    }
}