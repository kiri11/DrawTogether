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

        public void SwitchToStagesWindow()
        { }

        public void SwitchToLevelsWindow()
        { }

        public void SwitchToGameWindow()
        { }

        public void ShowPauseDialog()
        { }
    }
}
