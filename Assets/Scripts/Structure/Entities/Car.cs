using UnityEngine;

namespace Giereczka.Structure.Entities
{
    public class Car : IEntity
    {
        public float speed { get; private set; }
        public float rotSpeed { get; private set; }
        public float attackDamage { get; set; }

        public Car(float speed, float rotSpeed,float attackDamage)
        {
            this.speed = speed;
            this.rotSpeed = rotSpeed;
            this.attackDamage = attackDamage;
        }
    }
}
