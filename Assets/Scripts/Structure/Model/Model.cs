using System;
using Giereczka.Structure.Entities;

namespace Giereczka.Structure.Model
{
    public abstract class Model<T> where T : IEntity
    {
        public abstract T Build();
    }
}
