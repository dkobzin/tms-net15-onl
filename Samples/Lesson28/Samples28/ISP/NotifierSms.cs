namespace Samples28.ISP;

public class NotifierSms : Notifier, ISms
{
    public override void Send()
    {
        throw new NotImplementedException();
    }

    public void SendSms()
    {
        throw new NotImplementedException();
    }
}