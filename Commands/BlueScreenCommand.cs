using BlueScreen.Helpers;
using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueScreen.Commands
{
    public class BlueScreenCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "BlueScreen";

        public string Help => "BlueScreen";

        public string Syntax => "BlueScreen <Target>";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "BTBlueScreen.BlueScreen" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;
            if(command.Length < 1)
            {
                TranslationHelper.SendMessageTranslation(player.CSteamID, "ProperUsage", "/BlueScreen <Target>");
                return;
            }
            var target = UnturnedPlayer.FromName(command[0]);
            if(target == null)
            {
                TranslationHelper.SendMessageTranslation(player.CSteamID, "TargetNotFound");
                return;
            }
            if (BlueScreen.Instance.BlueScreens.Contains(target.CSteamID.m_SteamID))
            {
                // Remove BlueScreen
                EffectManager.askEffectClearByID(18000, target.Player.channel.owner.transportConnection);
                TranslationHelper.SendMessageTranslation(player.CSteamID, "BlueScreenRemoved", target.CharacterName);
                BlueScreen.Instance.BlueScreens.Remove(target.CSteamID.m_SteamID);
            }
            EffectManager.sendUIEffect(18000, 180, target.Player.channel.owner.transportConnection ,true);
            TranslationHelper.SendMessageTranslation(player.CSteamID, "BlueScreened", target.CharacterName);
            BlueScreen.Instance.BlueScreens.Add(target.CSteamID.m_SteamID);
        }
    }
}
