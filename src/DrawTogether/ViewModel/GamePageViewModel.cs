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
    public partial class GamePageViewModel : Page
    {

        private UserInteractionService _userInteractionService;
        private int _gameModeId;
        private int _boxId;
        private int _levelId;

        public GamePageViewModel(UserInteractionService userInteractionService, int gameModeId, int boxId, int levelId)
        {
            _userInteractionService = userInteractionService;
            _gameModeId = gameModeId;
            _boxId = boxId;
            _levelId = levelId;

            InitializeComponent();

            gamePage_PauseDialog.Visibility = System.Windows.Visibility.Hidden;
            gamePage_PauseButton.Click += gamePage_PauseButton_Click;
            gamePage_ResumeButton.Click += gamePage_ResumeButton_Click;
            gamePage_ExitButton.Click += gamePage_ExitButton_Click;
        }


        //Загрушки:
        void gamePage_ExitButton_Click(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToStartPage();
        }

        void gamePage_ResumeButton_Click(object sender, RoutedEventArgs e)
        {
            gamePage_PauseDialog.Visibility = System.Windows.Visibility.Hidden;
        }

        void gamePage_PauseButton_Click(object sender, RoutedEventArgs e)
        {
            gamePage_PauseDialog.Visibility = System.Windows.Visibility.Visible;
        }


    }
}

