using UnityEngine;
using Giereczka.Model;
using Giereczka.Core;

namespace Giereczka.Mechanics
{
    public class PlayerController : MonoBehaviour
    {
        public bool controlEnabled = true;


        readonly GameModel gameModel = Simulation.GetModel<GameModel>();
        private void Awake()
        {
        }
        private void Start()
        {
        }

        public void Update()
        {
        }

        private void FixedUpdate()
        {
        }

    }
}
