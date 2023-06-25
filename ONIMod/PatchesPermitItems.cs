using Database;
using HarmonyLib;

namespace ONISkinMod
{
	public class Patches
	{
		[HarmonyPatch(typeof(PermitItems))]
		[HarmonyPatch("GetOwnedCount")]
		public class PermitItemsGetOwnedCountPatch
		{
			
			public static void Postfix(ref int __result)

			{
				__result++;
				Debug.Log("I execute after PermitItems.GetOwnedCount!");
			}

			//public static void Postfix()
			//{
			//	Debug.Log("I execute after Db.Initialize!");
			//}
		}
	}
}
