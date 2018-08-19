using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace NetCoreWebJob.WebJob
{
    public class Functions
    {
        private readonly ILogger<Functions> logger;

        public Functions(ILogger<Functions> logger)
        {
            this.logger = logger;
        }

        public void ProcessQueueMessage([TimerTrigger("* * * * *")]TimerInfo timerInfo)
        {
            logger.LogInformation(DateTime.Now.ToString());
        }
    }
}
