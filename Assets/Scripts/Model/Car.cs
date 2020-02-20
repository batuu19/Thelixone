using UnityEngine;

namespace Giereczka.Model
{
    public class Car
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
