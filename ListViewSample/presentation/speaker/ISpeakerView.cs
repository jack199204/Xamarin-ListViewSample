using System;
using System.Reactive;
using System.Collections.Generic;
using ListViewSample.presentation.@base;

namespace ListViewSample.presentation.speaker
{
    public interface ISpeakerView : IBaseView
    {
        void UpdateActivityIndicator(bool show);

        void UpdateSpeakerListView(IList<SpeakerListViewEntity> entity);

        IObservable<EventPattern<object>> LoadButtonClicks();
    }
}
