using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace ListViewSample.domain
{
    public abstract class UseCase<T, Params>
    {
        protected IScheduler scheduler;

        protected abstract IObservable<T> Build(Params @params);

        public IObservable<T> Execute(Params @params)
        {
            return this.Build(@params).SubscribeOn(this.scheduler);
        }
    }
}
