using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Collections.Generic;
using ListViewSample.presentation.@base;

namespace ListViewSample.presentation.speaker
{
    public partial class SpeakerListPage : BasePage, ISpeakerView
    {
        private readonly SpeakerPresenter presenter;

        public SpeakerListPage()
        {
            InitializeComponent();

            this.presenter = new SpeakerPresenter(this, this.useCaseProvider.GetSpeakerListUseCase());
            this.presenter.Start();
        }

        ~SpeakerListPage()
        {
            this.presenter.Destroy();
        }

        public void UpdateView(IList<SpeakerListViewEntity> entities)
        {
            this.speakerListView.ItemsSource = entities;
        }

        public IObservable<EventPattern<object>> LoadButtonClicks()
        {
            return Observable.FromEventPattern(this.loadButton, "Clicked");
        }
    }
}
