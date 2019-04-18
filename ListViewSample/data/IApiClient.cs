using System;

namespace ListViewSample.data
{
    public interface IApiClient<Request, Response>
    {
        IObservable<Response> StartRequest(Request request);
    }
}
