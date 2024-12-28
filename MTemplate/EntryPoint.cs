using PluginAPI.Core;
using NwTemplate.Configs;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

namespace NwTemplate
{

    public class EntryPoint
    {
        public static EntryPoint Singleton { get; private set; }
        
        [PluginPriority(LoadPriority.Highest)]
        [PluginEntryPoint("SimPle", "1.0.0", "共创项目", "SimPle")]
        void LoadPlugin()
        {
            Singleton = this;
            Log.Info("正在加载插件中....");
            EventManager.RegisterEvents<EventHandlers>(this);
            Log.Info($"插件加载完成");
        }

        [PluginConfig] public MainConfig PluginConfig;
    }

    internal class EventHandlers
    {
    }
}