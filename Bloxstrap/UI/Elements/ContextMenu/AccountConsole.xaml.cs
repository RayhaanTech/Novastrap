using System.Windows;
using Novastrap.UI.ViewModels;

namespace Novastrap.UI.Elements.ContextMenu
{
    public partial class AccountManagerWindow
    {
        public AccountManagerWindow()
        {
            InitializeComponent();
            DataContext = new AccountBackupsViewModel();
        }
    }
}
