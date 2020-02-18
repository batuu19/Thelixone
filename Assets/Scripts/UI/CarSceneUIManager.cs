using UnityEngine;
using UnityEngine.SceneManagement;

namespace Giereczka.UI
{
    public class CarSceneUIManager : MonoBehaviour
    {
        public Canvas pauseMenu;
        bool inPauseMenu = false;
        private void Start()
        {
            pauseMenu.enabled = false;
        }
        private void Update()
        {
            if (Input.GetButtonDown("Cancel"))
            {
                if (!inPauseMenu)
                    EnterPauseMenu();
                else
                    ExitPauseMenu();
            }
        }
        public void EnterPauseMenu()
        {
            inPauseMenu = true;
            pauseMenu.enabled = true;
            Time.timeScale = 0;
        }
        public void ExitPauseMenu()
        {
            inPauseMenu = false;
            pauseMenu.enabled = false;
            Time.timeScale = 1;
        }
        public void ExitToMainMenu()
        {
            SceneManager.LoadScene("MainMenuScene");
        }
        public void ExitToWorld()
        {
            SceneManager.LoadScene("World");
        }


        public void Quit()
        {
            Application.Quit();
        }
    }
}
