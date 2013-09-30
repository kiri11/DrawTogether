using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DrawTogether.Model;
using System.Windows;

namespace DrawTogether.ViewModel
{
    public partial class BoxesPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;
        private GameType _gameType;

        public BoxesPageViewModel(UserInteractionService userInteractionService, GameType gameType)
        {
            _userInteractionService = userInteractionService;
            _gameType = gameType;
            InitializeComponent();

        }

        private void OnBoxItemClick(object sender, RoutedEventArgs e)
        {
            int boxId = 0;

            _userInteractionService.SwitchToLevelsWindow(_gameType, boxId);
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToPlayersWindow();
        }
    }
}
