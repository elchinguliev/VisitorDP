using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDP
{
    internal class MarketingNotificationCenter : INotificationSender
    {
        public void Accept(IVisitor visitor)
        {
           visitor.Visit(this);
        }

        public void Send(string message)
        {
            Console.WriteLine($"Notification send : { message}");
        }
    }
}
