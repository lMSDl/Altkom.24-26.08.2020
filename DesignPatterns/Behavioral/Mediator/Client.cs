using DesignPatterns.Behavioral.ChainOfResponsibility.I;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var chat = new Chat();

            ChatMember user1 = new ChatUser("User1");
            ChatMember bot = new ChatBot("Bot");

            user1.Chat = chat;
            bot.Chat = chat;

            string @string;
            do
            {
                @string = Console.ReadLine();
                var split = @string.Split(':');
                if (split.Length == 2)
                    user1.Send(split[0], split[1]);
                else
                    user1.Send(@string);

            } while (@string != "quit");
        }
    }
}
