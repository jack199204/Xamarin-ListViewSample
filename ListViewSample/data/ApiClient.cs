using System;
using System.Net.Http;

namespace ListViewSample.data
{
    public abstract class ApiClient<Request, Response> : IApiClient<Request, Response>
    {
        protected static HttpClient Client { get { return new HttpClient(); } }

        protected abstract IObservable<Response> StartClientRequest(Request request);

        public IObservable<Response> StartRequest(Request request)
        {
            return this.StartClientRequest(request);
        }
    }
}
