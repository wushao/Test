using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace CoreMini
{
    public class HttpContext
    {
        public HttpRequest Request { get; set;
        }
        public HttpResponse Response { get; set; }
    }

    public class HttpRequest {
        public Uri Url { get; }
        public NameValueCollection Headers { get; }
        
        public Stream Body { get; }

    }
    public class HttpResponse {

        public NameValueCollection Header { get; }

        public Stream Body { get; }

        public int StatusCode { get; set; }
    }
}
