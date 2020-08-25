﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.II
{
    public interface IMessageSenderImplementation
    {
        void SendMessage(string message);
    }
}
