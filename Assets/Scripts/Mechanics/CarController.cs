﻿using UnityEngine;
using Giereczka.Model;
using Giereczka.Core;

namespace Giereczka.Mechanics
{
    public class CarController : MonoBehaviour
    {
        Car car;
        float moveAcc = 0f;
        float moveRot = 0f;
        private Rigidbody2D body;
        private Collider2D collider2d;
        private SpriteRenderer spriteRenderer;
        internal float damage = 30;
        readonly GameModel gameModel = Simulation.GetModel<GameModel>();
        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
            collider2d = GetComponent<Collider2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
            car = gameModel.car;
        }
        private void Start()
        {
            body.gravityScale = 0;
        }

        public void Update()
        {
            moveRot = Input.GetAxisRaw("Horizontal");
            moveAcc = Input.GetAxisRaw("Vertical");
        }

        private void FixedUpdate()
        {
            body.velocity = transform.rotation * Vector2.up * moveAcc * Time.deltaTime * car.speed;

            if (moveRot == 0f)
                body.angularVelocity = 0f;

            transform.Rotate(Vector3.back, Mathf.Clamp(moveRot, -1f, 1f) * Time.deltaTime * car.rotSpeed);
        }
    }
}
