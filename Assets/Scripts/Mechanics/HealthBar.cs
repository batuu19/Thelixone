using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Giereczka.Mechanics
{
    public class HealthBar : MonoBehaviour
    {
        SpriteRenderer sprite;
        SquareEnemyController squareEnemyController;
        float startXScale;

        public float Health { get; private set; }
        float maxHealth;
        bool maxHealthInitialized = false;

        private void Awake()
        {
            sprite = GetComponent<SpriteRenderer>();
            squareEnemyController = GetComponentInParent<SquareEnemyController>();
        }

        private void Start()
        {
            startXScale = transform.localScale.x;   
        }

        public void InitializeMaxHealth(float maxHealth)
        {
            if(!maxHealthInitialized)
            {
                this.maxHealth = maxHealth;
                Health = maxHealth;
                maxHealthInitialized = true;
                
            }
        }

        public void OnTakeDamage(float value)
        {
            if (maxHealthInitialized)
            {
                Health -= value;
                float percentage = Health / maxHealth;
                var oldVector = transform.localScale;
                transform.localScale = new Vector3(startXScale * percentage, oldVector.y, oldVector.z);



                if (Health <= 0)
                {
                    Health = 0;
                    squareEnemyController.OnDye();
                }
            }
        }

    }

}

