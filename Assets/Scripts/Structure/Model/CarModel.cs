using UnityEngine;
using Giereczka.Structure.Entities;

namespace Giereczka.Structure.Model
{
    public class CarModel : Model<Car>
    {
        //public GameObject carPrefab;//?
        public float speed { get; set; } = 400f;
        public float rotSpeed { get; set; } = 150f;
        public float attackDamage { get; set; } = 30f;

        public override Car Build() => new Car(speed, rotSpeed,attackDamage);
    }
}

