using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giereczka.Model
{
    public class CharacterModel
    {
        public float speed = 100f;

        public Character Build() => new Character(speed);
    }
}
