using Demo2.UserComponents;

namespace Demo2.MyWorkerService
{
    public class GreetingService : BackgroundService
    {
        private readonly ILogger<GreetingService> _logger;

        public GreetingService( ILogger<GreetingService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            UserService userService = new ();

            while(!cancellationToken.IsCancellationRequested)
            {
               // _logger.LogInformation("My worker service running at : {time}", DateTimeOffset.Now);

            foreach(User user in userService.GetUser())
            {
                SmsService smsService = new (); 
                smsService.SendSms(user);
            }    
            await Task.Delay(1000, cancellationToken);

            }
        }
    }
}