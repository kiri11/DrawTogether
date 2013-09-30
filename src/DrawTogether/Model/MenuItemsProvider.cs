using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using DrawTogether.Extensions;

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
                items[i].Id = int.Parse(modeDirs[i].Split('_').LastOrDefault());
                items[i].GameModeId = items[i].Id;

                if (items[i].Id == 0)
                {
                    items[i].Title = "4 игрока"; //Переопределить под локализацию
                    items[i].BoxItems = GetMenuBoxItems(items[i].Id, modeDirs[i]);
                }
                if (items[i].Id == 1)
                {
                    items[i].Title = "3 игрока"; //Переопределить под локализацию
                    items[i].BoxItems = GetMenuBoxItems(items[i].Id, modeDirs[i]);
                }
                if (items[i].Id == 2)
                {
                    items[i].Title = "2 игрока"; //Переопределить под локализацию
                    items[i].BoxItems = GetMenuBoxItems(items[i].Id, modeDirs[i]);
                }
            }
                
            return items;
        }

        public MenuBoxItem[] GetMenuBoxItems(int gameModeId, string path)
        {
            MenuBoxItem[] items = null;

            string[] boxDirs = Directory.GetDirectories(path);
            items = new MenuBoxItem[boxDirs.Count()];

            for (int i = 0; i < items.Count(); i++)
            {
                items[i] = new MenuBoxItem();
                items[i].Id = int.Parse(boxDirs[i].Split('_').LastOrDefault());
                items[i].Title = "Stage " + (items[i].Id + 1);
                items[i].GameModeId = gameModeId;

                items[i].LevelItems = GetMenuLevelItems(gameModeId, boxDirs[i]);
            }

            return items;
        }

        public MenuLevelItem[] GetMenuLevelItems(int gameModeId, string path)
        {
            MenuLevelItem[] items = null;

            string[] levelDirs = Directory.GetDirectories(path);
            items = new MenuLevelItem[levelDirs.Count()];

            for (int i = 0; i < items.Count(); i++)
            {
                items[i] = new MenuLevelItem();
                items[i].Id = int.Parse(levelDirs[i].Split('_').LastOrDefault());
                items[i].Title = "Level " + (items[i].Id + 1);
                items[i].GameModeId = gameModeId;
            }

            return items;
        }
    }
}
