using UnityEngine;

namespace Giereczka.Model
{
    public class Player : IEntity
    {

        public Car car { get; private set; }
        public Character character { get; private set; }
        public Player()
        {
            car = Car.GetInitCar();
            character = Character.GetInitCharacter();

        }
    }
}
