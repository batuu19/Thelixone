using Giereczka.Core;
using Giereczka.Model;

namespace Giereczka.Gameplay
{
    /// <summary>
    /// This event is fired when user input should be enabled.
    /// </summary>
    public class EnablePlayerInput : Simulation.Event<EnablePlayerInput>
    {

        GameModel gameModel = Simulation.GetModel<GameModel>();

        public override void Execute()
        {
            var player = gameModel.player;
            player.controlEnabled = true;
        }

    }
}

