
using Giereczka.Core;
using Giereczka.Model;
using System.IO;
using UnityEngine;

namespace Giereczka.Mechanics
{
    public class MainMenuController : SceneController
    {
        protected void Awake()
        {
            if (!Directory.Exists(Application.persistentDataPath))
            {
                Directory.CreateDirectory(Application.persistentDataPath);
            }

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
