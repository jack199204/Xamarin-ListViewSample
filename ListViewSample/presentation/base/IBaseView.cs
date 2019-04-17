using System;
namespace ListViewSample.presentation.@base
{
    public interface IBaseView
    {
        void ShowErrorDialog(string title, string message, Action callback);
    }
}
