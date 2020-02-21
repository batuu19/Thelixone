using System;
using UnityEngine;

namespace Giereczka.Model
{
    [Serializable]
    public class Player : Entity
    {
        [SerializeField]
        Car _car;
        [SerializeField]
        Character _character;

        public Car car { get => _car; private set => _car = value; }
        public Character character { get => _character; private set => _character = value; }

        public Player()
        {
            car = Car.GetInitCar();
            character = Character.GetInitCharacter();
            character.spawnPoint = spawnPoint;
        }
    }
}
