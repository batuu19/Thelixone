using Giereczka.Mechanics;
using UnityEngine;

namespace Giereczka.Model
{
    [System.Serializable]
    public class GameModel
    {
        public Cinemachine.CinemachineVirtualCamera virtualCamera;

        public PlayerModel initPlayer;

        public CharacterModel initCharacter;

        public CarModel initCar;
    }
}
