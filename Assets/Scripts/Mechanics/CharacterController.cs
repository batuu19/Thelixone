using UnityEngine;
using Giereczka.Model;
using Giereczka.Core;

namespace Giereczka.Mechanics
{
    public class CharacterController : MonoBehaviour
    {
        Animator animator;
        Vector2 move;
        Rigidbody2D body;
        Character character;

        readonly GameModel gameModel = Simulation.GetModel<GameModel>();

        private void Awake()
        {
            animator = GetComponent<Animator>();
            body = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            move = Vector2.zero;
            character = gameModel.character;
        }

        private void Update()
        {
            float axisVert = Input.GetAxisRaw("Vertical");
            float axisHor = Input.GetAxisRaw("Horizontal");

            move = (Vector2.up * axisVert) + (Vector2.right * axisHor);
            
            if (axisVert == 0 && axisHor == 0) animator.SetBool("isWalking", false);
            else animator.SetBool("isWalking", true);
        }

        private void FixedUpdate()
        {
            body.velocity = move * Time.deltaTime * character.speed;
            var dir = body.velocity;
            float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.back);
        }
    }
}
