using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipeline
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Request
    {
        public StringBuilder Head { get; set; }

        public RequestClientType ClientType { get; set; }

        public RequestContent Content { get; set; }
    }
    public class RequestClientType
    {
        public const string App = "App";

        public const string NetClient = ".NET Client2.0";

        internal string type;
    }
    public class RequestContent
    {
        public string Content { get; set; }
    }
    public class RequestClientTypeFactroy
    {
        public static RequestClientType CreateRequestClientTypeForApp()
        {
            return new RequestClientType() { type = RequestClientType.App };
        }

        public static RequestClientType CreateRequestClientTypeForNet2()
        {
            return new RequestClientType() { type = RequestClientType.NetClient };
        }
    }
    public class ClientPipelineModules
    {
        public static void CheckRequestContent(Request request)
        {
            if (request == null || request.Content == null || string.IsNullOrEmpty(request.Content.Content))
            {
                throw new InvalidOperationException("无效请求");
            }
        }

        public static void AddRequestHead(Request request)
        {
            request.Head.Append("Request source:soa client");
        }

        public static void TransferRequestFormat(Request request)
        {

        }

        public static void ReduceRequest(Request request)
        {

        }
    }

    public delegate void ClientPipelingObjectModules(Request request);
    public class ClientPipelineObject
    {
        private ClientPipelingObjectModules modules;

        public void AddModule(ClientPipelingObjectModules module)
        {
            modules += modules;
        }

        public void RunPipeline(Request request)
        {
            modules(request);
        }
    }


}
