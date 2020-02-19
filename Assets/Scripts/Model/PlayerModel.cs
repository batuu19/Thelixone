using Giereczka.Core;

namespace Giereczka.Model
{
    public class PlayerModel
    {
        CharacterModel character;
        CarModel car;
        readonly GameModel gameModel = Simulation.GetModel<GameModel>();
    }
}
