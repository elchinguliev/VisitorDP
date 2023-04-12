﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDP
{
    internal interface INotificationSender
    {
        void Send(string message);
        void Accept(IVisitor visitor);
    }
}
