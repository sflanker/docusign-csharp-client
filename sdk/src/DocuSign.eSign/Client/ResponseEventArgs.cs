using System;
using RestSharp;

namespace DocuSign.eSign.Client
{
    public class ResponseEventArgs : EventArgs
    {
        public IRestRequest Request { get; }
        public IRestResponse Response { get; }

        public ResponseEventArgs(IRestRequest request, IRestResponse response)
        {
            this.Request = request;
            this.Response = response;
        }
    }
}