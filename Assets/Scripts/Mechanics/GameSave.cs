using System;
using System.IO;
using System.Text;
using Giereczka.Core;
using Giereczka.Model;

using UnityEngine;

namespace Giereczka.Mechanics
{
    [Serializable]
    public class GameSave
    {
        [SerializeField]
        Player playerData;
        [SerializeField]
        DateTime dateTime;
        [SerializeField]
        Vector2 lastSeen;

        public static readonly string gameSavePath = $"{Application.persistentDataPath}\\Save";
        public static readonly string gameSaveFile = $"{Application.persistentDataPath}\\Save\\gamesave.json";

        public static void Save(Vector2 pos)
        {
            //xml?
            //binary data?
            string json = JsonUtility.ToJson(new GameSave()
            {
                playerData = Simulation.player,
                dateTime = DateTime.Now,
                lastSeen = pos
            });
            if (!Directory.Exists(gameSavePath))
                Directory.CreateDirectory(gameSavePath);
            File.WriteAllText(gameSaveFile,json);

        }
        public static Vector2 Load()
        {
            StreamReader reader = new StreamReader(gameSaveFile);
            string json = reader.ReadLine();

                if (json != string.Empty)
                {
                    var save = JsonUtility.FromJson<GameSave>(json);
                    Simulation.player = save.playerData;
                    return save.lastSeen;
                }
                else
                {
                    Simulation.player = new Player();
                    return Vector2.zero;
                }
        }
    }
}
