using UnityEngine;
using UnityEngine.SceneManagement;

namespace Giereczka.Mechanics
{
    /// <summary>
    /// Base class for controlling scene with some useful methods
    /// </summary>
    public class SceneController : MonoBehaviour
    {

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void LoadSceneAdditive(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }

        public void ExitToMainMenu()
        {
            LoadScene("MainMenuScene");
        }

        public void ExitToWorld()
        {
            LoadScene("World");
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}
