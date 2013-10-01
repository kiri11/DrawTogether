using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DrawTogether.ViewModel
{
    public partial class GameModesPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;
        private MenuGameModeItem[] _gameModeItems;

        public GameModesPageViewModel(UserInteractionService userInteractionService, MenuGameModeItem[] gameModeItems)
        {
            _userInteractionService = userInteractionService;
            _gameModeItems = gameModeItems;
            InitializeComponent();

            gameModePage_listBox.ItemsSource = gameModeItems;
            gameModePage_listBox.SelectionChanged += OnGameModeItemClick;
        }

        private void OnGameModeItemClick(object sender, RoutedEventArgs e)
        {
            int gameModeId = ((ListBox)sender).SelectedIndex;
            _userInteractionService.SwitchToBoxesPage(gameModeId);
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToStartPage();
        }
    }
}
