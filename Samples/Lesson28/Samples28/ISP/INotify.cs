using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples28.ISP
{
    internal interface INotify
    {
        void SendSms();
        void SendMail();
        void SendPush();
    }
}
