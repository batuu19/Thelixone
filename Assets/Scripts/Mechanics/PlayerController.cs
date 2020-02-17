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
        private Vector2 move;
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
                move.x = Input.GetAxis("Horizontal");
                move.y = Input.GetAxis("Vertical");
            }
            else
                move = Vector2.zero;
        }

        private void FixedUpdate()
        {
            transform.Rotate(Vector3.back, Mathf.Clamp(move.x, -1, 1) * Time.deltaTime * rotationSpeed);

            body.velocity = transform.rotation * Vector2.up * move.y * Time.deltaTime * speed;
        }

        private void ComputeVelocity()
        {

        }

    }
}
