using System;
using System.Collections.Generic;

namespace ListViewSample.domain.speaker
{
    public interface ISpeakerRepository
    {
        IObservable<IList<Speaker>> GetSpeakers();
    }
}
