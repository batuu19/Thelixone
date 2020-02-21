using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Giereczka.Mechanics
{
    /// <summary>
    /// Base class for controlling scene with some useful methods
    /// </summary>
    public class SceneController : MonoBehaviour
    {
        public Canvas pauseMenu;
        public bool inPauseMenu = false;

        protected void Start()
        {
            pauseMenu.enabled = inPauseMenu;
        }

        protected void Update()
        {
            if (Input.GetButtonDown("Cancel"))
            {
                if (!inPauseMenu)
                    EnterPauseMenu();
                else
                    ExitPauseMenu();
            }
        }

        protected void OnDestroy()
        {
            Time.timeScale = 1;
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

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
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
