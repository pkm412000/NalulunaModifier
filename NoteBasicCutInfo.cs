﻿using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NalulunaModifier
{
    [HarmonyPatch(typeof(NoteBasicCutInfo))]
	[HarmonyPatch("GetBasicCutInfo")]
	internal static class NoteBasicCutInfoGetBasicCutInfo
	{
        static void Prefix(ref float saberBladeSpeed)
        {
            if (Config.boxing)
            {
                saberBladeSpeed = 3.0f;
            }
        }
    }
}
