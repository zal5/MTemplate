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
using PlayerRoles.RoleHelp;
using PlayerStatsSystem;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using UnityEngine;

namespace MTemplate
{
    internal class SCP035
    {
        Player Scp035;
        string Scp035之前的名字;
        string Scp035之前的颜色;

        [PluginEvent(ServerEventType.RoundRestart)]
        public void OnRoundRestart(Player 蔡徐坤, Player 吴亦凡)
        { 
            if (吴亦凡.Role == RoleTypeId.ClassD)
            {
                吴亦凡.AddItem(ItemType.SCP207);
                吴亦凡.Health = 300;
                吴亦凡.SendBroadcast("你是吴亦凡", 5);
            }
            if (蔡徐坤.Role == RoleTypeId.Scientist)
            {
                蔡徐坤.AddItem(ItemType.SCP207);
                蔡徐坤.Health = 200;
                蔡徐坤.SendBroadcast("你是蔡徐坤", 5);
            }
        }
        [PluginEvent(ServerEventType.PlayerDeath)]
        public void On玩家死亡(Player 攻击者, Player 被攻击者, DamageHandlerBase 伤害信息)
        {
            if (攻击者.Role == RoleTypeId.ClassD)
            {
                //E 
            }


        }

    }
}
