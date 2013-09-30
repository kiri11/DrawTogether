using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DrawTogether.ViewModel
{
    public partial class InteractionWindowViewModel : Window
    {
        private UserInteractionService _userInteractionService;
        private MenuGameModeItem[] _gameModeItems;

        public InteractionWindowViewModel()
        {
            //ниже перенести на экран загрузки!

            _gameModeItems = new MenuItemsProvider().GetMenuGameModeItems();

            _userInteractionService = new UserInteractionService(this, _gameModeItems);
            _gameModeItems = new MenuItemsProvider().GetMenuGameModeItems();

            InitializeComponent();

            _userInteractionService.SwitchToStartPage();
        }
    }
}
