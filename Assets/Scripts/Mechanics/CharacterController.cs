using UnityEngine;
using Giereczka.Model;
using Giereczka.Core;

namespace Giereczka.Mechanics
{
    public class CharacterController : PlayableController
    {
        Animator animator;
        Vector2 move;
        Rigidbody2D body;
        CharacterModel character;
        
        protected override void Init()
        {
            animator = GetComponent<Animator>();
            body = GetComponent<Rigidbody2D>();
        }

        protected override void PostInit()
        {
            move = Vector2.zero;
            character = gameModel.character;
        }

        protected override void ProcessInput()
        {
            float axisVert = Input.GetAxisRaw("Vertical");
            float axisHor = Input.GetAxisRaw("Horizontal");

            move = (Vector2.up * axisVert) + (Vector2.right * axisHor);

            if (axisVert == 0 && axisHor == 0) animator.SetBool("isWalking", false);
            else animator.SetBool("isWalking", true);
        }

        protected override void MakeCalculations()
        {
            body.velocity = move * Time.deltaTime * character.speed;
            var dir = body.velocity;
            float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.back);
        }
    }
}
