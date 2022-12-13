using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class SMS : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sended by SMS");
        }
    }
}
