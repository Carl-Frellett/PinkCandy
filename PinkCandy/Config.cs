using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCD
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;
        [Description("粉糖刷新倍率 默认为0.5 两次糖其中一颗为粉糖")]
        public float CandyWeight { get; set; } = 0.5f;
    }
}
