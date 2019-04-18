using System;
using Xamarin.Forms;
using ListViewSample.di;

namespace ListViewSample.presentation.@base
{
    public class BasePage : ContentPage, IBaseView
    {
        protected readonly UseCaseProvider useCaseProvider = new ProviderFactory().CreateUseCaseProvider();

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // iOS のみステータスバーの高さ分ずらす
            if (Device.RuntimePlatform == Device.iOS)
            {
                this.Padding = new Thickness(0.0, App.StatusBarHeight, 0.0, 0.0);
            }
        }

        public void ShowErrorDialog(string title, string message, Action callback)
        {
            async void alert()
            {
                await DisplayAlert(title, message, "OK");
                callback();
            }
            alert();
        }
    }
}
