
namespace ListViewSample.presentation.@base
{
    public abstract class Presenter<View>
    {
        protected readonly View view;

        protected Presenter(View view)
        {
            this.view = view;
        }

        public abstract void Start();
    }
}
