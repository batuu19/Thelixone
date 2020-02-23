
using Giereczka.Core;
using Giereczka.Model;
using Giereczka.Utils;
using System.IO;
using UnityEngine;

namespace Giereczka.Mechanics
{
    public class MainMenuController : SceneController
    {
        protected void Awake()
        {
            Simulation.savePath = $"{Application.persistentDataPath}//Save";
            Simulation.configPath = $"{Application.persistentDataPath}//Config";

            CustomFileUtils.CheckDirectory(Simulation.configPath);
            CustomFileUtils.CheckDirectory(Simulation.savePath);

        }

        public void LoadGame()
        {
            var pos = GameSave.Load();
            Simulation.player.character.spawnPoint = pos;
        }

        public void LoadSaveAndStartGame()
        {
            LoadGame();
            LoadScene("World");
        }

        public void StartNewGame()
        {
            Simulation.player = new Player();
            LoadScene("World");
        }
    }
}
