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

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.presenter.Destroy();
        }

        public void UpdateActivityIndicator(bool shows)
        {
            this.activityIndicator.IsRunning = shows;
        }

        public void UpdateSpeakerListView(IList<SpeakerListViewEntity> entities)
        {
            this.speakerListView.ItemsSource = entities;
        }

        public IObservable<Unit> LoadButtonClicks()
        {
            return Observable.FromEventPattern(this.loadButton, "Clicked").Select(_ => Unit.Default);
        }
    }
}
