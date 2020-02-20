using UnityEngine;
using Giereczka.Model;

namespace Giereczka.Mechanics
{

    public class SquareEnemyController : MonoBehaviour
    {
        SpriteRenderer sprite;
        Rigidbody2D body;
        Collider2D collider2d;
        HealthBar healthBar;

        private void Awake()
        {
            sprite = GetComponent<SpriteRenderer>();
            body = GetComponent<Rigidbody2D>();
            collider2d = GetComponent<Collider2D>();
            healthBar = GetComponentInChildren<HealthBar>();
        }
        // Start is called before the first frame update
        void Start()
        {
            healthBar.InitializeMaxHealth(100f);
        }

        // Update is called once per frame
        void Update()
        {
        }
        private void FixedUpdate()
        {

        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.tag == "Player")
            {
                CarController car = collision.collider.GetComponent<CarController>();
                float damage = car.AttackDamage;
                healthBar.OnTakeDamage(damage);
            }
        }

        public void OnDye()
        {
            gameObject.SetActive(false);
            //spawn another
        }
    }
}