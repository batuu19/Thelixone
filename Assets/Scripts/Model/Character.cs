using System.Collections.Generic;
using UnityEngine;

namespace Giereczka.Model
{
    public class Character : IEntity
    {
        public float speed { get; private set; }

        public static List<Character> characterModels = new List<Character>()
        {
            new Character{speed = 100f}
        };
        public static Character GetInitCharacter() => characterModels[0];
    }
}
