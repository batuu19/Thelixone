using Giereczka.Mechanics;
using UnityEngine;

namespace Giereczka.Model
{
    [System.Serializable]
    public class GameModel
    {
        public Camera camera;

        public Player player = new Player();

        public Character character = new Character();

        public Car car = new Car();
    }
}
