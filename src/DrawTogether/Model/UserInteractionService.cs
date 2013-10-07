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
        private MenuGameModeItem[] _gameModeItems;

        public UserInteractionService(InteractionWindowViewModel parentWindow, MenuGameModeItem[] gameModeItems)
        {
            _parentWindow = parentWindow;
            _gameModeItems = gameModeItems;
        }

        public void SwitchToStartPage()
        {
            _parentWindow.Content = new StartPageViewModel(this);
        }

        public void SwitchToGameModesPage()
        {
            _parentWindow.Content = new GameModesPageViewModel(this, _gameModeItems);
        }

        public void SwitchToBoxesPage(int gameModeId)
        {
            _parentWindow.Content = new BoxesPageViewModel(this, gameModeId, _gameModeItems[gameModeId].BoxItems);
        }

        public void SwitchToLevelsPage(int gameModeId, int boxId)
        {
            _parentWindow.Content = new LevelsPageViewModel(this, gameModeId, boxId, _gameModeItems[gameModeId].BoxItems[boxId].LevelItems);
        }

        public void SwitchToGamePage(GameSettings gameSettings)
        {
            _parentWindow.Content = new GamePageViewModel(this, gameSettings);           
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
