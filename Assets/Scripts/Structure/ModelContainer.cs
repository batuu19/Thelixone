using System;
using System.Collections.Generic;
using Giereczka.Core;
using Giereczka.Structure.Model;
using Giereczka.Structure.Entities;

namespace Giereczka.Structure
{
    public static class ModelContainer
    {
        public static List<CarModel> carModels = new List<CarModel>()
        {
            new CarModel{speed = 400f, rotSpeed = 150f, attackDamage = 30f},
            new CarModel{speed = 500f, rotSpeed = 250f, attackDamage = 60f},
        };

        public static List<CharacterModel> characterModels = new List<CharacterModel>()
        {
            new CharacterModel{speed = 100f}
        };


        public static Car GetInitCar() => carModels[1].Build();
        public static Character GetInitCharacter() => characterModels[0].Build();
        public static Player GetInitPlayer() => Simulation.GetModel<Player>();//needed?
    }
}
