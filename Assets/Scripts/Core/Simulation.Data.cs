using UnityEngine;
using Giereczka.Model;

namespace Giereczka.Core
{
    public static partial class Simulation
    {
        public static readonly string savePath = Application.persistentDataPath + "\\save";
        public static readonly string configPath = Application.persistentDataPath + "\\config";

        public static Player player;

    }
}
