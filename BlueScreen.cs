﻿using Rocket.API;
using Rocket.Core.Plugins;
using System;
using Logger = Rocket.Core.Logging.Logger;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;

namespace BlueScreen
{
    public partial class BlueScreen : RocketPlugin
    {
        public static BlueScreen Instance;
        public HashSet<ulong> BlueScreens = new HashSet<ulong>();
        protected override void Load()
        {
            Instance = this;
            Logger.Log("#############################################", ConsoleColor.Yellow);
            Logger.Log("###            BTBlueScreen Loaded          ###", ConsoleColor.Yellow);
            Logger.Log("###   Plugin Created By blazethrower320   ###", ConsoleColor.Yellow);
            Logger.Log("###            Join my Discord:           ###", ConsoleColor.Yellow);
            Logger.Log("###     https://discord.gg/YsaXwBSTSm     ###", ConsoleColor.Yellow);
            Logger.Log("#############################################", ConsoleColor.Yellow);
        }

        protected override void Unload()
        {
            Logger.Log("BTBlueScreen Unloaded");
        }
    }
}
