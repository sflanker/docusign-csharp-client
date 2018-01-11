using System;
using RestSharp;

namespace DocuSign.eSign.Client
{
    public class RequestEventArgs : EventArgs
    {
        public IRestRequest Request { get; }

        public RequestEventArgs(IRestRequest request)
        {
            this.Request = request;
        }
    }
}