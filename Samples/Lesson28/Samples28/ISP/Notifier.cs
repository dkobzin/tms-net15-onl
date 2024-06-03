namespace Samples28.ISP;

public abstract class Notifier // : INotify  // It;s not good!
{
    public abstract void Send();
    
    // It's not good
    /* public void SendSms()
    {
        throw new NotImplementedException();
    }

    public void SendMail()
    {
        throw new NotImplementedException();
    }

    public void SendPush()
    {
        throw new NotImplementedException();
    } */
}