using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using ListViewSample.domain.speaker;

namespace ListViewSample.data.speaker
{
    public class SpeakerRepository : ISpeakerRepository
    {
        public IObservable<IList<Speaker>> GetSpeakers()
        {
            return new SpeakerListApiClient().StartRequest(Unit.Default)
                .Select(entities => new SpeakerMapper().Transform(entities));
        }
    }
}
