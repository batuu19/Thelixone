
using Giereczka.Core;
using Giereczka.Model;

namespace Giereczka.Mechanics
{
    public class MainMenuController : SceneController
    {
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
