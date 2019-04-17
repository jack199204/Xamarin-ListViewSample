using System;
using System.Threading;
using System.Reactive;
using System.Reactive.Linq;
using ListViewSample.domain.speaker;
using ListViewSample.presentation.@base;
using System.Diagnostics;

namespace ListViewSample.presentation.speaker
{
    public class SpeakerPresenter : Presenter<ISpeakerView>
    {
        private readonly GetSpeakerListUseCase getSpeakerListUseCase;

        public SpeakerPresenter(ISpeakerView speakerView, GetSpeakerListUseCase getSpeakerListUseCase) : base(speakerView)
        {
            this.getSpeakerListUseCase = getSpeakerListUseCase;
        }

        public override void Start()
        {
            // ロードボタン押下
            this.disposables.Add(this.view.LoadButtonClicks()
                .Subscribe(_ =>
                {
                    this.disposables.Add(this.getSpeakerListUseCase.Execute(Unit.Default)
                        .ObserveOn(SynchronizationContext.Current)
                        .Subscribe(list =>
                        {
                            var viewEntities = new SpeakerListViewEntityMapper().Transform(list);
                            this.view.UpdateView(viewEntities);
                        }, error =>
                        {
                            Trace.WriteLine(error);
                            this.view.ShowErrorDialog("エラー", "取得に失敗しました。", () => { });
                        }));
                }));
        } 
    }
}
