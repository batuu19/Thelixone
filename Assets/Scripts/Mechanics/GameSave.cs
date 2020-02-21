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

        public static readonly string gameSavePath = $"{Application.persistentDataPath}\\Save\\gamesave.json";

        public static void Save(Vector2 pos)
        {
            string json = JsonUtility.ToJson(new GameSave()
            {
                playerData = Simulation.player,
                dateTime = DateTime.Now,
                lastSeen = pos
            });
            using (FileStream fs = File.Create(gameSavePath))
            {
                byte[] text = new UTF8Encoding(true).GetBytes(json);
                fs.Write(text,0,text.Length);
            }

        }
        public static Vector2 Load()
        {
            string json = File.ReadAllText(gameSavePath);//exception if not exits
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
