using Giereczka.Mechanics;
using Giereczka.Model;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Giereczka.Utils
{
    //add xml and binary
    public static class FileUtils
    {

        public static T[] LoadModelsFromJson<T>(string filename) where T : IEntity
        {
            StreamReader reader = new StreamReader(filename);
            string json = reader.ReadLine();
            if (json != string.Empty)
            {
                var models = JsonUtility.FromJson<ArrayWrapper<T>>(json);
                return models.Array;
            }
            else
            {
                return new T[0];
            }
        }
        public static T LoadFromJson<T>(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string json = reader.ReadLine();

            if (json != string.Empty)
            {
                return JsonUtility.FromJson<T>(json);
            }
            else
            {
                throw new FileNotFoundException("Json file not found");
            }
        }

        public static void SaveModelsToJson<T>(string filename,T[] models) where T : IEntity
        {
            SaveToJson(filename, new ArrayWrapper<T>(models));
        }

        public static void SaveToJson<T>(string filename, T obj)
        {
            string json = JsonUtility.ToJson(obj);
            File.WriteAllText(filename, json);
        }
    }
}
