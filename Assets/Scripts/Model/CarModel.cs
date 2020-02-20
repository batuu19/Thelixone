using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Giereczka.Model
{
    public class CarModel
    {
        //public GameObject carPrefab;//?
        public float speed { get; set; } = 400f;
        public float rotSpeed { get; set; } = 150f;
        public float attackDamage { get; set; } = 30f;

        public Car Build() => new Car(speed, rotSpeed,attackDamage);
    }
}

