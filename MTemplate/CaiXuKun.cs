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
    internal class CaiXuKun
    {
        Player Cxk;
        string Cxk之前的颜色 = "";
        string Cxk之前的称号 = "";
        //                服务器事件.回合开始
        [PluginEvent(ServerEventType.RoundRestart)]
        public void On回合开始()
        {
        //  回合开始5秒后
            Timing.CallDelayed(0.5f, () =>
            {
                foreach (Player player in Player.GetPlayers())
                {
                    //如果这个玩家的角色是科学家
                    if (player.Role == RoleTypeId.Scientist)
                    {
                        //玩家变成蔡徐坤
                        Cxk = player;
                        break;
                    }
                }
            });
            Cxk.RoleName = "蔡徐坤123";
            Cxk.RoleColor = "yellow";
            Cxk.AddItem(ItemType.GunCom45);
            Cxk.Health = 200;
            Cxk.SendBroadcast($"你是蔡徐坤" ,10);
        }
    }
}
