using UnityEngine;
using Giereczka.Core;
using Giereczka.Structure.Model;
using Giereczka.Structure.Entities;

namespace Giereczka.Mechanics
{
    /// <summary>
    /// Controller used by player
    /// </summary>
    public abstract class PlayableController :  MonoBehaviour
    {
        /// <summary>
        /// Will be processed in Awake()
        /// </summary>
        protected abstract void Init();
        /// <summary>
        /// Will be processed in Start()
        /// </summary>
        protected abstract void PostInit();
        /// <summary>
        /// Will be processed in Update()
        /// </summary>
        protected abstract void ProcessInput();
        /// <summary>
        /// Will be processed in FixedUpdate()
        /// </summary>
        protected abstract void MakeCalculations();

        
        private void Awake()
        {
            Init();
        }
        private void Start()
        {
            PostInit();
        }
        private void Update()
        {
            ProcessInput();
        }
        private void FixedUpdate()
        {
            MakeCalculations();
        }
    }
}
