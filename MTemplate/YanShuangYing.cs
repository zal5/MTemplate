using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomPlayerEffects;
using Interactables.Interobjects.DoorUtils;
using MEC;
using NwTemplate;
using NwTemplate.Configs;
using PlayerRoles;
using PlayerStatsSystem;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using UnityEngine;

namespace MTemplate
{
    internal class YanShuangYing
    {
        Player Ysy;
        string Ysy先前的颜色 = "";
        string Ysy先前的名称 = "";

        [PluginEvent(ServerEventType.RoundRestart)]
        public void OnRoundStarting()
        {
            if (EntryPoint.Singleton.PluginConfig.is_spawn_181)
            {
                Timing.CallDelayed(0.4f, () =>
                {
                    foreach (Player player in Player.GetPlayers())
                    {
                        if (player.Role == RoleTypeId.ClassD)
                        {
                            Ysy = player;
                            break;
                        }
                    }
                    Ysy先前的名称 = Ysy.RoleName;
                    Ysy先前的颜色 = Ysy.RoleColor;
                    Ysy.RoleName = "燕双鹰";
                    Ysy.RoleColor = "bule";
                    Ysy.Health = 120;
                    Ysy.AddItem(ItemType.GunCOM15);
                    Ysy.SendBroadcast("<color=green><size=35>[你是燕双鹰]</size></color>", 5);
                });
            }
        }
    }
}
