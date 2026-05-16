using System;
using March7thHoney.Enums.Mission;

namespace March7thHoney.GameServer.Game.Mission.FinishType;

public class MissionFinishTypeAttribute : Attribute
{
	public MissionFinishTypeEnum FinishType { get; private set; }

	public MissionFinishTypeAttribute(MissionFinishTypeEnum finishType)
	{
		FinishType = finishType;
		base._002Ector();
	}
}
