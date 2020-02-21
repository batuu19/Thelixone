using Giereczka.Core;
using Giereczka.Model;
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
            Config();
        }

        public void Config()
        {
            string json = JsonUtility.ToJson(ArrayWrapper<Car>.Get(carModels));
        }
    }
}