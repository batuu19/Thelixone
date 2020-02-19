using Giereczka.Mechanics;
using UnityEngine;

namespace Giereczka.Model
{
    [System.Serializable]
    public class GameModel
    {
        public Camera camera;

        public PlayerModel player = new PlayerModel();

        public CharacterModel character = new CharacterModel();

        public CarModel car = new CarModel();
    }
}
