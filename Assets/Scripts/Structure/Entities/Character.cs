using UnityEngine;

namespace Giereczka.Structure.Entities
{
    public class Character : IEntity
    {
        public float speed { get; private set; }

        public Character(float speed)
        {
            this.speed = speed;
        }
    }
}
