namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SMS sms = new SMS();
            Whatsapp whatsapp = new Whatsapp();
            Email email = new Email(); 

            List<INotification> notificationList = new List<INotification>();

            notificationList.Add(sms);
            notificationList.Add(whatsapp);
            notificationList.Add(email);

            Messenger messenger = new Messenger(notificationList);

            messenger.Send();
            

        }
    }
}