using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Giereczka.UI
{
    public class MainMenuUIManager : MonoBehaviour
    {

        private void Awake()
        {
            Debug.Log(Application.persistentDataPath);
        }

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}