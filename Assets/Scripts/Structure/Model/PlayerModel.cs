using Giereczka.Core;
using Giereczka.Structure.Entities;

namespace Giereczka.Structure.Model
{
    public class PlayerModel
    {
        public Player Build()
        {
            return new Player(
                new CarModel().Build(),
                new CharacterModel().Build()
                );
        }
    }
}
