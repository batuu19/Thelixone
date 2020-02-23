using System;
using System.IO;
using System.Text;
using Giereczka.Core;
using Giereczka.Model;
using Giereczka.Utils;


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

        public Player PlayerData { get => playerData; private set => playerData = value; }
        public DateTime DateTime { get => dateTime; private set => dateTime = value; }
        public Vector2 LastSeen { get => lastSeen; private set => lastSeen = value; }


        public static readonly string saveFile = Simulation.savePath + "\\gamesave.json";

        public GameSave(Player playerData, DateTime dateTime, Vector2 lastSeen)
        {
            this.PlayerData = playerData;
            this.DateTime = dateTime;
            this.LastSeen = lastSeen;
        }

        public static void Save(Vector2 pos)
        {
            //xml?
            //binary data?
            FileUtils.SaveToJson(saveFile, new GameSave(
                Simulation.player,
                DateTime.Now,
                pos
            ));

        }
        public static Vector2 Load()
        {
            var save = FileUtils.LoadFromJson<GameSave>(saveFile);

            Simulation.player = save.PlayerData;
            return save.LastSeen;
        }
    }
}
