using System;
using Xamarin.Forms;
using ListViewSample.di;

namespace ListViewSample.presentation.@base
{
    public class BasePage : ContentPage, IBaseView
    {
        protected readonly UseCaseProvider useCaseProvider = new ProviderFactory().CreateUseCaseProvider();

        public void ShowErrorDialog(string title, string message, Action callback)
        {
            Action alert = async () => 
            {
                await DisplayAlert(title, message, "OK");
                callback();
            };
            alert();
        }
    }
}
