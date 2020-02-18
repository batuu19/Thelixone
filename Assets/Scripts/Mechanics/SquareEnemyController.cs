using UnityEngine;
using Giereczka.Model;

namespace Giereczka.Mechanics
{

    public class SquareEnemyController : MonoBehaviour
    {
        SpriteRenderer sprite;
        Rigidbody2D body;
        Collider2D collider2d;

        public float maxHealth = 100f;
        float health;
        public bool IsAlive { get => health > 0f; }
        public bool dead = false;

        private void Awake()
        {
            sprite = GetComponent<SpriteRenderer>();
            body = GetComponent<Rigidbody2D>();
            collider2d = GetComponent<Collider2D>();
        }
        // Start is called before the first frame update
        void Start()
        {
            float health = maxHealth;
        }

        // Update is called once per frame
        void Update()
        {
            if(!dead && IsAlive)
            {
                dead = true;
                gameObject.SetActive(false);
            }
        }
        private void FixedUpdate()
        {

        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("OnCollisionEnter2D");
            if (collision.collider.tag == "Player")
            {
                CarController car = collision.collider.GetComponent<CarController>();
                float damage = car.damage;
                Debug.Log($"Took {damage} damage, {health} healt left");
            }
        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            Debug.Log("OnCollisionStay2D");

        }

        void TakeDamage(float value)
        {

        }
    }
}