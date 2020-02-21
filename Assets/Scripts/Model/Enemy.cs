using System;
using System.Collections.Generic;
using UnityEngine;

namespace Giereczka.Model
{
    [Serializable]
    public class Enemy : Entity
    {
        [SerializeField]
        private float _maxHealth;

        public float maxHealth { get => _maxHealth; private set => _maxHealth = value; }

        public static List<Enemy> enemyModels = new List<Enemy>()
        {
            new Enemy{maxHealth = 100f}
        };
    }
}
