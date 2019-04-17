using System;
using System.Collections.Generic;
using System.Reactive;

namespace ListViewSample.domain.speaker
{
    public interface ISpeakerRepository
    {
        IObservable<IList<Speaker>> GetSpeakers();
    }
}
