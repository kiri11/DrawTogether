using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DrawTogether.ViewModel
{
    public partial class PlayersPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;

        public PlayersPageViewModel(UserInteractionService userInteractionService)
        {
            _userInteractionService = userInteractionService;
            InitializeComponent();
        }

        private void OnTwoPlayersButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToBoxesWindow(PlayersCount.TwoPlayers);
        }

        private void OnThreePlayersButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToBoxesWindow(PlayersCount.ThreePlayers);
        }

        private void OnFourPlayersButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToBoxesWindow(PlayersCount.FourPlayers);
        }
    }
}
