using Novastrap.Integrations;
using Novastrap.UI.Elements.Base;
using Novastrap.UI.ViewModels.ContextMenu;

namespace Novastrap.UI.Elements.ContextMenu
{
    public partial class BetterBloxDataCenterConsole
    {
        public BetterBloxDataCenterConsole()
        {
            InitializeComponent();
            var vm = new BetterBloxDataCenterConsoleViewModel();
            DataContext = vm;
        }
    }
}
