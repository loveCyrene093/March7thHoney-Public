using System;
using System.Reflection;
using March7thHoney.GameServer.Game.Mission;
using March7thHoney.GameServer.Game.Mission.FinishAction;
using March7thHoney.GameServer.Game.Mission.FinishType;

namespace March7thHoney.GameServer.Server;

public static class ServerUtils
{
	public static void InitializeHandlers()
	{
		Type[] types = Assembly.GetExecutingAssembly().GetTypes();
		foreach (Type type in types)
		{
			MissionFinishActionAttribute customAttribute = type.GetCustomAttribute<MissionFinishActionAttribute>();
			if (customAttribute != null)
			{
				MissionFinishActionHandler value = (MissionFinishActionHandler)Activator.CreateInstance(type, null);
				MissionManager.ActionHandlers.Add(customAttribute.FinishAction, value);
			}
			MissionFinishTypeAttribute customAttribute2 = type.GetCustomAttribute<MissionFinishTypeAttribute>();
			if (customAttribute2 != null)
			{
				MissionFinishTypeHandler value2 = (MissionFinishTypeHandler)Activator.CreateInstance(type, null);
				MissionManager.FinishTypeHandlers.Add(customAttribute2.FinishType, value2);
			}
		}
	}
}
