using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostingServiceClientBase.Models
{
    public class ResponseModel<T>
    {
        public List<T> Result { get; set; }
        public List<string> Messages { get; set; }
        public List<string> TechnicalMessages { get; set; }

        public ResponseModel()
        {
            Messages = new List<string>();
            TechnicalMessages = new List<string>();
            Result = new List<T>();
        }
    }
}
