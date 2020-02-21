using Giereczka.Core;
using System;
using UnityEngine;

namespace Giereczka.Mechanics
{
    public class WorldController : GameSceneController
    {
        public GameObject character;
        CharacterController characterController;
        protected void Awake()
        {
            characterController = character.GetComponent<CharacterController>();
        }

        public void SaveGame()
        {
            GameSave.Save(new Vector2(character.transform.position.x, character.transform.position.y));
        }
    }
}
