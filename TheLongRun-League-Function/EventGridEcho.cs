// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.EventGrid.Models;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Microsoft.Extensions.Logging;

namespace TheLongRunLeaguesFunction
{
    public static class EventGridEcho
    {
        [FunctionName("EventGridEcho")]
        public static void EventGridEchoRun([EventGridTrigger] EventGridEvent eventGridEvent, 
            ILogger log)
        {
            log.LogInformation(eventGridEvent.Data.ToString());
        }
    }
}
