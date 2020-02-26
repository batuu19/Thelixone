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
        float rotSpeed = 150f;
        float handling = 0f;
        //temp end
        float moveAcc = 0f;
        float moveRot = 0f;
        private Rigidbody body;
        private SpriteRenderer spriteRenderer;

        static float lastVelZ;

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
            lastVelZ = body.velocity.z;
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
            var newVelocity = body.velocity + (transform.rotation * accelerationVector);//add acceleration to velocity
            body.velocity = Vector3.ClampMagnitude(newVelocity, maxSpeed);

            transform.Rotate(Vector3.up, Mathf.Clamp(moveRot, -1f, 1f) * Time.deltaTime * car.rotSpeed);//how to rotate velocity
            //rotating velocity
            body.velocity = transform.forward * body.velocity.magnitude;

            body.velocity = new Vector3(body.velocity.x, 0, body.velocity.z);

            Debug.Log(body.velocity);
            lastVelZ = body.velocity.z;
        }
    }
}
