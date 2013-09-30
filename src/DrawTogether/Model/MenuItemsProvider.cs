using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DrawTogether.Model
{
    public class MenuItemsProvider
    {
        private string dataDirPath = AppSettings.DataDirectoryPath;
        private string challengesDirPath {get {return dataDirPath + @"Challenges\";} set{}}

        public MenuGameModeItem[] GetMenuGameModeItems()
        {
            MenuGameModeItem[] items = null;

            string[] modeDirs = Directory.GetDirectories(challengesDirPath);
            items = new MenuGameModeItem[modeDirs.Count()];

            for (int i = 0; i < items.Count(); i++)
            {
                items[i] = new MenuGameModeItem();
                string modeId = modeDirs[i].Split('_')[1];

                if (modeId == "4x")
                {
                    items[i].GameMode = GameMode.FourPlayers;
                    items[i].BoxItems = GetMenuBoxItems(GameMode.FourPlayers);
                }
                if (modeId == "3x")
                {
                    items[i].GameMode = GameMode.ThreePlayers;
                    items[i].BoxItems = GetMenuBoxItems(GameMode.ThreePlayers);
                }
                if (modeId == "2x")
                {
                    items[i].GameMode = GameMode.TwoPlayers;
                    items[i].BoxItems = GetMenuBoxItems(GameMode.TwoPlayers);
                }
            }
                
            return items;
        }

        public MenuBoxItem[] GetMenuBoxItems(GameMode gameMode)
        {
            return null;
        }
    }
}
