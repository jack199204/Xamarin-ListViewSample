using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Concurrency;

namespace ListViewSample.domain.speaker
{
    public class GetSpeakerListUseCase : UseCase<IList<Speaker>, Unit>
    {
        private readonly ISpeakerRepository speakerRepository;

        public GetSpeakerListUseCase(ISpeakerRepository speakerRepository)
        {
            this.scheduler = Scheduler.CurrentThread;
            this.speakerRepository = speakerRepository;
        }

        protected override IObservable<IList<Speaker>> Build(Unit @params)
        {
            return this.speakerRepository.GetSpeakers();
        }
    }
}
