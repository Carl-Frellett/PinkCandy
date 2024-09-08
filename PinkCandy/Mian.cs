using Exiled.API.Features;
using System;

namespace PCD
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "PinkCandyReturns_EXILED";
        public override string Author => "omgiamhungarian";
        private static HarmonyLib.Harmony HI { get; set; }
        private static int Couter;
        private static readonly Lazy<Plugin> PLuginConfig = new Lazy<Plugin>(() => new Plugin());

        private PinkCandyPatch PC;
        public static Plugin ConfigINE => PLuginConfig.Value;
        public override void OnEnabled()
        {
            base.OnEnabled();

            PC = new PinkCandyPatch();
            HI = new HarmonyLib.Harmony($"{Name}{Couter++}");
            HI.PatchAll();

            Log.Info("粉糖加载完毕插件已加载 原作者omgiamhungarian EXILED版本作者Carl Frellett");
        }
        public override void OnDisabled()
        {
            PC = null;
            HI.UnpatchAll();

            base.OnDisabled();
        }
    }
}
