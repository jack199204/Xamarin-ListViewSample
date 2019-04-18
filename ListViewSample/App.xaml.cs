using Xamarin.Forms;
using ListViewSample.presentation.speaker;

namespace ListViewSample
{
    public partial class App : Application
    {
        public static double StatusBarHeight { get; set; } = 0.0;

        public App()
        {
            InitializeComponent();

            MainPage = new SpeakerListPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
