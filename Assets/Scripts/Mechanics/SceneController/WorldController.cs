using Giereczka.Core;
using System;
using UnityEngine;

namespace Giereczka.Mechanics
{
    public class WorldController : SceneController
    {
        public GameObject character;
        CharacterController characterController;
        protected new void Awake()
        {
            base.Awake();
            characterController = character.GetComponent<CharacterController>();
        }

        public void SaveGame()
        {
            GameSave.Save(new Vector2(character.transform.position.x, character.transform.position.y));
        }
    }
}
