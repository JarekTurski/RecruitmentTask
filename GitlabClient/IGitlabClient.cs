using HostingServiceClientBase.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitlabClient
{
    public interface IGitlabClient
    {
        Task<ResponseModel<Issue>> SendRequest<Issue>(HttpMethod method, string url, string content = null);
    }
}