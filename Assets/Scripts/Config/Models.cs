using Giereczka.Core;
using Giereczka.Model;
using Giereczka.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Giereczka.Config
{
    [System.Serializable]
    public class Models : MonoBehaviour
    {
        public Car[] carModels;
        public Character[] characterModels;


        private void Awake()
        {
            carModels = Car.carModels.ToArray();
            characterModels = Character.characterModels.ToArray();
        }
        public void LoadModels()
        {
            string fileCarModels = Simulation.configPath + "//carModels.json";
            string fileCharacterModels = Simulation.configPath + "//characterModels.json";


        }

        public void SaveModels()
        {
            string json = JsonUtility.ToJson(new ArrayWrapper<Car>(carModels));
        }

        

        public void Config()
        {
        }
    }
}