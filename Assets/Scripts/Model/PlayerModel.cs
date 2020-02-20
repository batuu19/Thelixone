using Giereczka.Core;

namespace Giereczka.Model
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
