﻿using MelonLoader;

namespace BuildableCairns
{
    internal class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Settings.instance.AddToModSettings(BuildInfo.Name);
            LoggerInstance.Msg($"Version {BuildInfo.Version}");
        }
    }
}
