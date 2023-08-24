using HostingServiceClientBase.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HostingServiceClientBase
{
    public abstract class HostingServiceClientBase
    {
        public abstract Task<ResponseModel<T>> SendRequest<T>(HttpMethod method, string url, string content = null);
   
        protected StringContent ContentToString(object content)
            => new StringContent(ToJson(content), Encoding.UTF8);

        protected string ToJson(object value)
            => JsonConvert.SerializeObject(value, Formatting.None);
    }
}
