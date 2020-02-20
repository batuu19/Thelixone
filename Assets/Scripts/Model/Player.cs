using UnityEngine;

namespace Giereczka.Model
{
    public class Player
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
