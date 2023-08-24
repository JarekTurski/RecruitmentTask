using GithubClient.Models;
using HostingServiceClientBase.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace GithubClient
{
    public interface IGithubClient
    {
        Task<ResponseModel<T>> SendRequest<T>(HttpMethod method, string url, string content = null);
    }
}