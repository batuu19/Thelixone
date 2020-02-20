using Giereczka.Structure.Entities;

namespace Giereczka.Structure.Model
{
    public class CharacterModel : Model<Character>
    {
        public float speed = 100f;

        public override Character Build() => new Character(speed);
    }
}
