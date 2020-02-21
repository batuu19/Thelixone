using System;
using System.Collections.Generic;
using UnityEngine;

namespace Giereczka.Model
{
    [Serializable]
    public class Character : Entity
    {
        [SerializeField]
        private float _speed;
        public float speed { get => _speed; private set => _speed = value; }

        public static List<Character> characterModels = new List<Character>()
        {
            new Character{speed = 100f}
        };

        public static Character GetInitCharacter() => characterModels[0];
    }
}
