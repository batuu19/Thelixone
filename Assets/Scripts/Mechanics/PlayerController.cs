using UnityEngine;
using Giereczka.Model;
using Giereczka.Core;

namespace Giereczka.Mechanics
{
    public class PlayerController : MonoBehaviour
    {
        public bool controlEnabled = true;
        private float speed = 400f;
        private float rotationSpeed = 150f;
        private float acceleration = 0f;
        private float rotational = 0f;
        private Rigidbody2D body;
        private Collider2D collider2d;
        private SpriteRenderer spriteRenderer;


        readonly GameModel gameModel = Simulation.GetModel<GameModel>();
        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
            collider2d = GetComponent<Collider2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        private void Start()
        {
            body.gravityScale = 0;
        }

        public void Update()
        {
            if (controlEnabled)
            {
                rotational = Input.GetAxisRaw("Horizontal");
                acceleration = Input.GetAxisRaw("Vertical");
            }
            else
            {
                acceleration = 0f;
                rotational = 0f;
            }

        }

        private void FixedUpdate()
        {
            body.velocity = transform.rotation * Vector2.up * acceleration * Time.deltaTime * speed;

            if (rotational == 0f)
                body.angularVelocity = 0f;

            transform.Rotate(Vector3.back, Mathf.Clamp(rotational, -1f, 1f) * Time.deltaTime * rotationSpeed);



        }

        private void ComputeVelocity()
        {

        }

    }
}
