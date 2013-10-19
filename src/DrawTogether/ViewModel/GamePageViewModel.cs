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
        private GameProcessor _gameProcessor;
        private GameSettings _gameSettings;
        
        public GamePageViewModel(UserInteractionService userInteractionService, GameSettings gameSettings)
        {
            _userInteractionService = userInteractionService;
            _gameSettings = gameSettings;

            InitializeComponent();
            
            _gameProcessor = new GameProcessor(_gameSettings);
            
            //перенести всё в xaml Binding
            //gamePage_player1PreviewImage.Source = _gameSettings.Player1.SourceBitmap;
            //gamePage_player2PreviewImage.Source = _gameSettings.Player2.SourceBitmap;
            //gamePage_player3PreviewImage.Source = _gameSettings.Player3.SourceBitmap;
            //gamePage_player4PreviewImage.Source = _gameSettings.Player4.SourceBitmap;

            //gamePage_player1InkCanvas.Background = new SolidColorBrush(_gameSettings.Player1.PlayerColor);
            //gamePage_player2InkCanvas.Background = new SolidColorBrush(_gameSettings.Player2.PlayerColor);
            //gamePage_player3InkCanvas.Background = new SolidColorBrush(_gameSettings.Player3.PlayerColor);
            //gamePage_player4InkCanvas.Background = new SolidColorBrush(_gameSettings.Player4.PlayerColor);

            //gamePage_player1InkCanvas.Background.Opacity = 0.1;
            //gamePage_player2InkCanvas.Background.Opacity = 0.1;
            //gamePage_player3InkCanvas.Background.Opacity = 0.1;
            //gamePage_player4InkCanvas.Background.Opacity = 0.1;

            //gamePage_player1InkCanvas.DefaultDrawingAttributes.Color = _gameSettings.Player1.PlayerColor;
            //gamePage_player2InkCanvas.DefaultDrawingAttributes.Color = _gameSettings.Player2.PlayerColor;
            //gamePage_player3InkCanvas.DefaultDrawingAttributes.Color = _gameSettings.Player3.PlayerColor;
            //gamePage_player4InkCanvas.DefaultDrawingAttributes.Color = _gameSettings.Player4.PlayerColor;




            gamePage_PauseDialog.Visibility = System.Windows.Visibility.Hidden;
            gamePage_PauseButton.Click += OnPauseButtonClick;
            gamePage_ResumeButton.Click += ResumeButtonClick;
            gamePage_ExitButton.Click += OnExitButtonClick;

            _gameProcessor.TopTimerTick += OnTopTimerTick;
            _gameProcessor.BottomTimerTick += OnBottomTimerTick;

            //поехали
            _gameProcessor.OnStart();
        }

        private void OnBottomTimerTick(object sender, string e)
        {
            gamePage_BottomTimerLabel.Content = e;
        }

        private void OnTopTimerTick(object sender, string e)
        {
            gamePage_TopTimerLabel.Content = e;
        }

        private void OnExitButtonClick(object sender, RoutedEventArgs e)
        {
            _userInteractionService.SwitchToStartPage();
        }

        private void ResumeButtonClick(object sender, RoutedEventArgs e)
        {
            gamePage_PauseDialog.Visibility = System.Windows.Visibility.Hidden;
            _gameProcessor.OnResume();
        }

        private void OnPauseButtonClick(object sender, RoutedEventArgs e)
        {
            gamePage_PauseDialog.Visibility = System.Windows.Visibility.Visible;
            _gameProcessor.OnStop();
        }
    }
}

