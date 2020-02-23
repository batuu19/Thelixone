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


        string fileCarModels;
        string fileCharacterModels;

        private void Awake()
        {
            carModels = Car.carModels.ToArray();
            characterModels = Character.characterModels.ToArray();
        }
        private void Start()
        {
            fileCarModels = $"{Simulation.configPath}//carModels.json";
            fileCharacterModels = $"{Simulation.configPath}//characterModels.json";
        }
        public void LoadModels()
        {
            carModels = CustomFileUtils.LoadModelsFromJson<Car>(fileCarModels);
            characterModels = CustomFileUtils.LoadModelsFromJson<Character>(fileCharacterModels);
        }

        public void SaveModels()
        {
            CustomFileUtils.SaveModelsToJson(fileCarModels, carModels);
            CustomFileUtils.SaveModelsToJson(fileCharacterModels, characterModels);
        }
    }
}