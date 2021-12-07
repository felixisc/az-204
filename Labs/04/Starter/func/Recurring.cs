using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace func
{
    public class Recurring
    {
        public class MyConfig
        {
            public string OutputString { get; set; }
        }
        [FunctionName("Recurring")]
        
        public static void Run([TimerTrigger("%TimerInterval%")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
