﻿namespace NalulunaModifier
{
    public static class Config
    {
        public static BS_Utils.Utilities.Config config = new BS_Utils.Utilities.Config(Plugin.Name);
        
        public static bool parabola = false;
        public static float parabolaOffsetY = 1.8f;
        public static bool noBlue = false;
        public static bool noRed = false;
        public static bool redToBlue = false;
        public static bool blueToRed = false;

        public static bool boxing = false;
        public static bool hideSabers = false;
        public static bool hideSaberEffects = false;
        public static bool centering = false;

        public static bool headbang = false;
        public static bool superhot = false;
        public static bool vacuum = false;

        public static void Read()
        {
            parabola = config.GetBool(Plugin.Name, "parabola", false, true);
            parabolaOffsetY = config.GetFloat(Plugin.Name, "parabolaOffsetY", 1.8f);
            noBlue = config.GetBool(Plugin.Name, "noBlue", false, true);
            noRed = config.GetBool(Plugin.Name, "noRed", false, true);
            redToBlue = config.GetBool(Plugin.Name, "redToBlue", false, true);
            blueToRed = config.GetBool(Plugin.Name, "blueToRed", false, true);

            boxing = config.GetBool(Plugin.Name, "boxing", false, true);
            hideSabers = config.GetBool(Plugin.Name, "hideSabers", false, true);
            hideSaberEffects = config.GetBool(Plugin.Name, "hideSaberEffects", false, true);
            centering = config.GetBool(Plugin.Name, "centering", false, true);

            headbang = config.GetBool(Plugin.Name, "headbang", false, true);
            superhot = config.GetBool(Plugin.Name, "superhot", false, true);
            vacuum = config.GetBool(Plugin.Name, "vacuum", false, true);
        }

        public static void Write()
        {
            config.SetBool(Plugin.Name, "parabola", parabola);
            config.SetFloat(Plugin.Name, "parabolaOffsetY", parabolaOffsetY);
            config.SetBool(Plugin.Name, "boxing", boxing);
            config.SetBool(Plugin.Name, "hideSabers", hideSabers);
            config.SetBool(Plugin.Name, "hideSaberEffects", hideSaberEffects);

            config.SetBool(Plugin.Name, "centering", centering);
            config.SetBool(Plugin.Name, "noBlue", noBlue);
            config.SetBool(Plugin.Name, "noRed", noRed);
            config.SetBool(Plugin.Name, "redToBlue", redToBlue);
            config.SetBool(Plugin.Name, "blueToRed", blueToRed);

            config.SetBool(Plugin.Name, "headbang", headbang);
            config.SetBool(Plugin.Name, "superhot", superhot);
            config.SetBool(Plugin.Name, "vacuum", vacuum);
        }
    }
}
