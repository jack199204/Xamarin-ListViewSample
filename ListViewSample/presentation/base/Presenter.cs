using System.Reactive.Disposables;

namespace ListViewSample.presentation.@base
{
    public abstract class Presenter<View>
    {
        protected readonly View view;
        protected readonly CompositeDisposable disposables = new CompositeDisposable();

        protected Presenter(View view)
        {
            this.view = view;
        }

        public abstract void Start();

        public void Destroy()
        {
            this.disposables.Clear();
        }
    }
}
