using GitlabClient.Models;
using HostingServiceClientBase;
using HostingServiceClientBase.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GitlabClient
{
    public class GitlabClient : HostingServiceClientBase.HostingServiceClientBase, IGitlabClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger _logger;
        public GitlabClient(IHttpClientFactory httpClientFactory, ILogger<IHttpClientFactory> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public override async Task<ResponseModel<Issue>> SendRequest<Issue>(HttpMethod method, string url, string content = null)
        {
            List<string> technicalMessages = new List<string>();
            if (method.Equals(HttpMethod.Post) || method.Equals(HttpMethod.Put))
            {
                var validationResult = CreateIssueValidator.Validate<Issue>(content, _logger);
                if (validationResult != null)
                    technicalMessages.Add(validationResult);
            }
            using (HttpResponseMessage response = await DoRequest(method, url, content))
            {
                try
                {
                    var result = await ResponseInterpreter.ReadResponse<Issue>(response);
                    return result;
                }
                catch (Exception ex)
                {
                    ResponseModel<Issue> obj = new ResponseModel<Issue>();
                    obj.TechnicalMessages.Add(ex.ToString());
                    _logger.LogError(ex.Message + ex.StackTrace);
                    return obj;
                }
            }
        }
        private async Task<HttpResponseMessage> DoRequest(HttpMethod method, string endpoint, string content)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();

            // TODO: Authorization required for all operations that modify issues
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "YOUR-TOKEN");
            UriBuilder builder = new UriBuilder($"{Constants.BaseUri}{endpoint}");
            var uri = builder.Uri;

            switch (method.ToString().ToUpper())
            {
                case "GET":
                    return await httpClient.GetAsync(uri);
                case "POST":
                    return await httpClient.PostAsync(uri, ContentToString(content));
                case "PUT":
                    return await httpClient.PutAsync(uri, ContentToString(""));
                case "DELETE":
                    return await httpClient.DeleteAsync(uri);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
