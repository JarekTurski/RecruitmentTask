using HostingServiceClientBase.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HostingServiceClientBase
{
    public static class ResponseInterpreter
    {
        public static async Task<ResponseModel<T>> ReadResponse<T>(HttpResponseMessage httpResponseMessage)
        {
            string body;
            string message = string.Empty;
            if(!httpResponseMessage.IsSuccessStatusCode)
            {
                body = string.Empty;
                message = httpResponseMessage.StatusCode.ToString();
            }
            else 
                body = await httpResponseMessage.Content.ReadAsStringAsync();
            return ParseResponse<T>(body, message);
        }

        private static ResponseModel<T> ParseResponse<T>(string body, string message)
        {
            ResponseModel<T> response = new ResponseModel<T>();
            if(!string.IsNullOrEmpty(message))
                response.TechnicalMessages.Add(message);
            try
            {
                response.Result = JsonConvert.DeserializeObject<List<T>>(body);
            }
            catch (Exception ex)
            {
                throw new JsonSerializationException("Cannot deserialize response.", ex);
            }
            return response;
        }
    }
}
