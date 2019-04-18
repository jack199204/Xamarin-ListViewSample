using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using Newtonsoft.Json;
using ListViewSample.domain.speaker;

namespace ListViewSample.data.speaker
{
    public class SpeakerListApiClient : ApiClient<Unit, IList<SpeakerResponseEntity>>
    {
        private readonly string url = "http://demo4404797.mockable.io/speakers";

        protected override IObservable<IList<SpeakerResponseEntity>> StartClientRequest(Unit request)
        {
            return Observable.Create<IList<SpeakerResponseEntity>>(async observer => {
                try
                {
                    var json = await Client.GetStringAsync(this.url);
                    var entities = JsonConvert.DeserializeObject<IList<SpeakerResponseEntity>>(json);
                    observer.OnNext(entities);
                }
                catch (Exception exception)
                {
                    observer.OnError(exception);
                }
            });
        }
    }
}
