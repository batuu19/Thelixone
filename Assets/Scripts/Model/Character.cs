using UnityEngine;

namespace Giereczka.Model
{
    public class Character
    {
        public float speed { get; private set; }

        public Character(float speed)
        {
            this.speed = speed;
        }
    }
}
