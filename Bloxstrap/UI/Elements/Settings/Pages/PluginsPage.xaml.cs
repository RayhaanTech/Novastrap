using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Wpf.Ui.Controls;
using Wpf.Ui.Hardware;
using Novastrap.UI.Elements.Dialogs;
using Novastrap.UI.ViewModels.Settings;
using System.Collections.ObjectModel;

namespace Novastrap.UI.Elements.Settings.Pages
{
    public partial class PluginsPage
    {
        public PluginsPage()
        {
            InitializeComponent();
            DataContext = new PluginsViewModel();
        }
    }
}

