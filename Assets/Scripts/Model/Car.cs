using System;
using System.Collections.Generic;
using UnityEngine;

namespace Giereczka.Model
{
    [Serializable]
    public class Car : Entity
    {
        [SerializeField]
        private int _id;
        [SerializeField]
        private float _speed;
        [SerializeField]
        private float _rotSpeed;
        [SerializeField]
        private float _attackDamage;//TODO make sure > 0

        public int id { get => _id; private set => _id = value; }
        public float speed { get => _speed; private set => _speed = value; }
        public float rotSpeed { get => _rotSpeed; private set => _rotSpeed = value; }
        public float attackDamage { get => _attackDamage; private set => _attackDamage = value; }

        private Car() { }

        public Car(int id, float speed, float rotSpeed, float attackDamage)
        {
            _id = id;
            _speed = speed;
            _rotSpeed = rotSpeed;
            _attackDamage = attackDamage;
        }

        public static List<Car> carModels = new List<Car>()
        {
            new Car{id = 0,speed = 400f, rotSpeed = 150f, attackDamage = 30f},
            new Car{id = 1,speed = 500f, rotSpeed = 250f, attackDamage = 60f},
        };

        public static Car GetInitCar() => carModels[0];
    }
}
