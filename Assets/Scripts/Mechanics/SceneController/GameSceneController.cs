using UnityEngine;

namespace Giereczka.Mechanics
{
    /// <summary>
    /// Adds methods for pausing game
    /// </summary>
    public class GameSceneController : SceneController
    {
        public Canvas pauseMenu;//find gameobject?
        bool inPauseMenu = false;
        //PlayableController ?

        private void Start()
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
    }
}
