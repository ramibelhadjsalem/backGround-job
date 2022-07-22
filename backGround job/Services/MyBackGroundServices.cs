namespace backGround_job.Services
{

    public class MyBackGroundServices : BackgroundService
    {

        public readonly ILogger<MyBackGroundServices> Logger ;
        public MyBackGroundServices(ILogger<MyBackGroundServices> logger)
        {
            this.Logger = logger;
        }

        

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                this.Logger.LogInformation("form my background");
                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
           
            
        }
    }
}
