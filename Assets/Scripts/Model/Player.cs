using Giereczka.Core;

namespace Giereczka.Model
{
    public class Player
    {
        Character character;
        Car car;
        readonly GameModel gameModel = Simulation.GetModel<GameModel>();
    }
}
