using UnityEngine;
using Giereczka.Model;
using Giereczka.Core;

namespace Giereczka.Mechanics
{
    public class CarController : PlayableController
    {
        CarModel car;
        float moveAcc = 0f;
        float moveRot = 0f;
        private Rigidbody2D body;
        private Collider2D collider2d;
        private SpriteRenderer spriteRenderer;

        public float AttackDamage { get; private set; } = 30;

        protected override void Init()
        {
            body = GetComponent<Rigidbody2D>();
            collider2d = GetComponent<Collider2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
            car = gameModel.car;//that's what I'm working on
        }

        protected override void PostInit()
        {
            body.gravityScale = 0;
        }

        protected override void ProcessInput()
        {
            moveRot = Input.GetAxisRaw("Horizontal");
            moveAcc = Input.GetAxisRaw("Vertical");
        }

        protected override void MakeCalculations()
        {
            body.velocity = transform.rotation * Vector2.up * moveAcc * Time.deltaTime * car.speed;

            if (moveRot == 0f)
                body.angularVelocity = 0f;

            transform.Rotate(Vector3.back, Mathf.Clamp(moveRot, -1f, 1f) * Time.deltaTime * car.rotSpeed);
        }
    }
}
