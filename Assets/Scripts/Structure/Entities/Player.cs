using UnityEngine;

namespace Giereczka.Structure.Entities
{
    public class Player : IEntity
    {

        public Car car { get; private set; }
        public Character character { get; set; }
        public Player(Car car, Character character)
        {
            this.car = car;
            this.character = character;
        }
    }
}
