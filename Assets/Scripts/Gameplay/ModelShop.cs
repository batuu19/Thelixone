using System;
using Giereczka.Structure.Model;
using Giereczka.Structure.Entities;
using System.Collections.Generic;

namespace Giereczka.Gameplay
{
    public abstract class ModelShop<T> //where T : Model<IEntity> //I want that!
    {
        List<T> models;

        public T GetModel(int index)
        {
            if (index >= models.Count)
                return models[0];
            else
                return models[index];
        }
    }
}
