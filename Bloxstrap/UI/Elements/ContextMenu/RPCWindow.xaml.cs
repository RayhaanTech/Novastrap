using System.Windows;
using Novastrap.UI.ViewModels;
using Novastrap.UI.ViewModels.ContextMenu;

namespace Novastrap.UI.Elements.ContextMenu
{
    public partial class RPCWindow
    {
        public RPCWindow()
        {
            InitializeComponent();
            DataContext = new RPCCustomizerViewModel();
        }
    }
}
