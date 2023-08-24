using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HostingServiceClientBase
{
    public class CreateIssueValidator
    {
        public static string Validate<T>(string content, ILogger logger)
        {
            try
            {
                T issue = JsonConvert.DeserializeObject<T>(content);
            }
            catch (JsonException ex)
            {
                logger.LogError(ex.Message);
                return ex.Message;
            }
            return null;
        }
        
    }
}
