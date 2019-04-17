using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reactive.Linq;
using Newtonsoft.Json;
using ListViewSample.domain.speaker;

namespace ListViewSample.data.speaker
{
    public class SpeakerRepository : ISpeakerRepository
    {
        private readonly static HttpClient client = new HttpClient();

        public IObservable<IList<Speaker>> GetSpeakers()
        {
            return Observable.Create<IList<Speaker>>(async observer => {
                string url = "http://demo4404797.mockable.io/speakers";
                try
                {
                    string json = await client.GetStringAsync(url);
                    List<SpeakerResponseEntity> entities = JsonConvert.DeserializeObject<List<SpeakerResponseEntity>>(json);
                    var speakerList = new SpeakerMapper().Transform(entities);
                    observer.OnNext(speakerList);
                }
                catch(Exception exception)
                {
                    observer.OnError(exception);
                }
            });
        }
    }
}
