using DrawTogether.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTogether.Model
{
    public class UserInteractionService
    {
        private InteractionWindowViewModel _parentWindow;

        public UserInteractionService(InteractionWindowViewModel parentWindow)
        {
            _parentWindow = parentWindow;
        }

        public void SwitchToStartWindow()
        {
            _parentWindow.Content = new StartPageViewModel(this);
        }

        public void SwitchToPlayersWindow()
        {
            _parentWindow.Content = new PlayersPageViewModel(this);
        }

        public void SwitchToBoxesWindow(GameMode gameMode)
        {
            _parentWindow.Content = new BoxesPageViewModel(this, gameMode);
        }

        public void SwitchToLevelsWindow(GameMode gameMode, int boxId)
        {
            _parentWindow.Content = new LevelsPageViewModel(this, gameMode, boxId);
        }

        public void SwitchToGameWindow(GameMode GameMode, int boxId, int levelId)
        {
            _parentWindow.Content = new GamePageViewModel(this, GameMode, boxId, levelId);            
        }

        public void ShowPauseDialog()
        {
        }

        public void CloseApplication()
        {
            _parentWindow.Close();
        }
    }
}
