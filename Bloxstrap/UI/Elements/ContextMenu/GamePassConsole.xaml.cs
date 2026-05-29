using Novastrap.Integrations;
using Novastrap.UI.Elements.Base;
using Novastrap.UI.ViewModels.ContextMenu;

namespace Novastrap.UI.Elements.ContextMenu
{
    public partial class GamePassConsole
    {
        public GamePassConsole(long userId)
        {
            InitializeComponent();
            var vm = new GamePassConsoleViewModel();
            DataContext = vm;
            vm.LoadGamePassesCommand.Execute(userId);
        }
    }
}
