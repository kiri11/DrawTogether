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

        GameProcessor asd;

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



            //test
            var gs = new GameSettings();
            gs.TopTimerTimeSpan = new TimeSpan(0, 1, 0);
            gs.BottomTimerTimeSpan = new TimeSpan(0, 2, 0);
            asd = new GameProcessor(gs);
            asd.OnStart();
            asd.TopTimerTick += asd_TopTimerTick;            
        }

        void asd_TopTimerTick(object sender, string e)
        {
            gamePage_TopTimerLabel.Content = e;
            gamePage_BottomTimerLabel.Content = e;
        }


        //Загрушки:
        void gamePage_ExitButton_Click(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToStartPage();
        }

        void gamePage_ResumeButton_Click(object sender, RoutedEventArgs e)
        {
            gamePage_PauseDialog.Visibility = System.Windows.Visibility.Hidden;
            asd.OnResume();
        }

        void gamePage_PauseButton_Click(object sender, RoutedEventArgs e)
        {
            gamePage_PauseDialog.Visibility = System.Windows.Visibility.Visible;
            asd.OnStop();
        }
    }
}

