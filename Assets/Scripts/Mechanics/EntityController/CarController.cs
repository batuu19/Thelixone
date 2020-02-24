using UnityEngine;
using Giereczka.Core;
using Giereczka.Model;

namespace Giereczka.Mechanics
{
    public class CarController : PlayableController
    {
        Car car;

        //temp. TODO move to model
        float acceleration = 70f;
        float maxSpeed = 50f;
        float handling = 0f;
        //temp end
        float moveAcc = 0f;
        float moveRot = 0f;
        private Rigidbody body;
        private SpriteRenderer spriteRenderer;

        public float AttackDamage => car.attackDamage;

        protected override void Init()
        {
            body = GetComponent<Rigidbody>();
            //Because debug
            Simulation.player = new Player();
            car = Simulation.player.car;
        }

        protected override void PostInit()
        {
        }

        protected override void ProcessInput()
        {
            moveAcc = Input.GetAxisRaw("Vertical");
            moveRot = Input.GetAxisRaw("Horizontal");
        }

        protected override void MakeCalculations()
        {
            //body.AddForce(Vector3.forward * moveAcc * Time.deltaTime * acceleration);
            var accelerationVector = Vector3.forward * acceleration * moveAcc * Time.deltaTime;
            var newVelocity = body.velocity + (transform.rotation * accelerationVector);

            if(newVelocity.magnitude < maxSpeed)
            {
                body.velocity = newVelocity;
            }
            else
            {
                body.velocity = body.velocity.normalized * maxSpeed;

            }
            Debug.Log(body.velocity.magnitude);
            transform.Rotate(Vector3.up, Mathf.Clamp(moveRot, -1f, 1f) * Time.deltaTime * car.rotSpeed);
        }
    }
}
