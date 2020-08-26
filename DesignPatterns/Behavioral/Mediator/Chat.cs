using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Chat : IChatMediator
    {
        private ICollection<ChatMember> _chatMembers = new List<ChatMember>();

        public void Join(ChatMember member)
        {
            _chatMembers.Add(member);
        }

        public void Notify(string from, string message)
        {
            _chatMembers.Where(x => x.Nick != from).ToList().ForEach(x => x.Receive(from, message, false));
        }

        public void Notify(string from, string to, string message)
        {
            _chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }

        public void Quit(ChatMember member)
        {
            _chatMembers.Remove(member);
        }
    }
}
