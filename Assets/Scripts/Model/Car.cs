using System.Collections.Generic;
using UnityEngine;

namespace Giereczka.Model
{
    public class Car : IEntity
    {
        public float speed { get; private set; }
        public float rotSpeed { get; private set; }
        public float attackDamage { get; private set; }

        public static List<Car> carModels = new List<Car>()
        {
            new Car{speed = 400f, rotSpeed = 150f, attackDamage = 30f},
            new Car{speed = 500f, rotSpeed = 250f, attackDamage = 60f},
        };
        public static Car GetInitCar() => carModels[0];
    }
}
