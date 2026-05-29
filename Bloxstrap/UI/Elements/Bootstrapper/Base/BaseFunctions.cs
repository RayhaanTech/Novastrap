using System;
using System.Windows;

namespace Novastrap.UI.Elements.Bootstrapper.Base
{
    static class BaseFunctions
    {
        public static void ShowSuccess(string message, Action? callback = null)
        {
            Frontend.ShowMessageBox(message, MessageBoxImage.Information);
            callback?.Invoke();

            App.Terminate();
        }
    }
}
