using System.Collections.Generic;

namespace NwTemplate.Configs
{
	public class MainConfig
    {
        public bool debug { get; private set; } = false;
        //是否启用Scp-181
        public bool is_spawn_181 { get; private set; } = true;
        //是否启用燕双鹰
        public bool is_spawn_Ysy {  get; private set; } = true;
        //是否启用蔡徐坤
        public bool is_spawn_Cxk {  get; private set; } = true;
    }
}