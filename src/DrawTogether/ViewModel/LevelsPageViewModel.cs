using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawTogether.ViewModel
{
    public partial class LevelsPageViewModel : Page
    {
        private UserInteractionService _userInteractionService;
        private int _gameModeId;
        private MenuLevelItem[] _levelItems;
        private int _boxId;
        private GameFactory _gameFactory;

        public LevelsPageViewModel(UserInteractionService userInteractionService, int gameModeId, int boxId, MenuLevelItem[] levelItems)
        {
            _userInteractionService = userInteractionService;
            _gameFactory = new GameFactory();

            _gameModeId = gameModeId;
            _levelItems = levelItems;
            _boxId = boxId;
            InitializeComponent();

            levelsPage_listBoxDataBinding.ItemsSource = levelItems;
            levelsPage_listBoxDataBinding.SelectionChanged += OnLevelItemClick;
        }

        private void OnLevelItemClick(object sender, RoutedEventArgs e)
        {
            int levelId = ((ListBox)sender).SelectedIndex;
            _userInteractionService.SwitchToGamePage(_gameFactory.GetSettings(_gameModeId, _boxId, levelId));
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToBoxesPage(_gameModeId);
        }
    }
}
