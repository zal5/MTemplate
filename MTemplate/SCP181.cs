using Interactables.Interobjects.DoorUtils;
using MEC;
using NwTemplate.Configs;
using PlayerRoles;
using PlayerStatsSystem;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using UnityEngine;

namespace NwTemplate
{
    internal class SCP181
    {
        Player Scp181;
        string Scp181先前的颜色 = "";
        string Scp181先前的名称 = "";

        [PluginEvent(ServerEventType.RoundStart)]
        public void OnRoundStarting()
        {
            if (EntryPoint.Singleton.PluginConfig.is_spawn_181) 
            {
                Timing.CallDelayed(0.3f, () => 
                {
                    foreach (Player ply in Player.GetPlayers())
                    {
                        if (ply.Role == RoleTypeId.ClassD)
                        {
                            Scp181 = ply;
                            break;
                        }
                    }
                    Scp181先前的名称 = Scp181.RoleName;
                    Scp181先前的颜色 = Scp181.RoleColor;
                    Scp181.RoleName = "SCP-181";
                    Scp181.RoleColor = "orange";
                    Scp181.AddItem(ItemType.KeycardO5);
                    Scp181.SendBroadcast("<color=green><size=35>[你是181]</size></color>", 5);
                });
            }
        }
        [PluginEvent(ServerEventType.PlayerInteractDoor)]
        public void On玩家与门交互(Player 开门的玩家, DoorVariant 要开的门, bool 能不能打开)
        {
            if (开门的玩家 == Scp181 && 能不能打开 == false)
            {
                int 随机数 = Random.Range(1, 100);
                if (随机数 <= 50)
                {
                    要开的门.NetworkTargetState = !要开的门.NetworkTargetState;
                    开门的玩家.SendBroadcast("开门成功", 1);
                }
            }
        }
        [PluginEvent(ServerEventType.PlayerDeath)]
        public void OnPlayerDeath(Player 受击者, Player 攻击者, DamageHandlerBase damageHandler)
        {
            if (受击者 == Scp181)
            {
                受击者.RoleName = Scp181先前的名称;
                受击者.RoleColor = Scp181先前的颜色;
                Scp181 = null;
            }
        }
    }
}
