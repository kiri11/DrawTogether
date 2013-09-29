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

        public void SwitchToBoxesWindow(PlayersCount playersCount)
        {
            _parentWindow.Content = new BoxesPageViewModel(this, playersCount);
        }

        public void SwitchToLevelsWindow(PlayersCount playersCount, int boxId)
        {
            _parentWindow.Content = new LevelsPageViewModel(this, playersCount, boxId);
        }

        public void SwitchToGameWindow(PlayersCount playersCount, int boxId, int levelId)
        {
            _parentWindow.Content = new GamePageViewModel(this, playersCount, boxId, levelId);            
        }

        public void ShowPauseDialog()
        {
        }
    }
}
