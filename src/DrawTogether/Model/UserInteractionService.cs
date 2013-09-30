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

        public void SwitchToBoxesWindow(GameType gameType)
        {
            _parentWindow.Content = new BoxesPageViewModel(this, gameType);
        }

        public void SwitchToLevelsWindow(GameType gameType, int boxId)
        {
            _parentWindow.Content = new LevelsPageViewModel(this, gameType, boxId);
        }

        public void SwitchToGameWindow(GameType GameType, int boxId, int levelId)
        {
            _parentWindow.Content = new GamePageViewModel(this, GameType, boxId, levelId);            
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
