using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Giereczka.Mechanics
{
    public class PlaceEnter : MonoBehaviour
    {
        bool inTrigger = false;
        public string sceneName;
        // Update is called once per frame
        void Update()
        {
            if (Input.GetAxisRaw("Take Action") > 0 && inTrigger)
            {
                if (sceneName != string.Empty)
                    SceneManager.LoadScene(sceneName);
                else
                    Debug.LogError("Scene not defined");
            }
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.tag == "Player")
            {
                inTrigger = true;
                Debug.Log("You Entered Collision, press E to enter Home");
            }
        }
        private void OnTriggerExit2D(Collider2D collider)
        {
            if (collider.tag == "Player")
            {
                inTrigger = false;
                Debug.Log("You Exited Collision, press E to go to Home");
            }
        }
    }
}