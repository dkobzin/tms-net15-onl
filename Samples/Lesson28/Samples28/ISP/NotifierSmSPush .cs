using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples28.ISP
{
    internal class NotifierSmSPush : Notifier, ISms, IPusher
    {
        public void SendSms()
        {
            throw new NotImplementedException();
        }

        public override void Send()
        {
            throw new NotImplementedException();
        }

        public void SendPush()
        {
            throw new NotImplementedException();
        }
    }
}
