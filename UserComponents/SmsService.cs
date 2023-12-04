namespace Demo2.UserComponents
{
    public class SmsService
    {
        public void SendSms(User user)
        {
            System.Console.WriteLine($"Send Christmas greetings to {user.PhoneNumber}");
        }
    }
}