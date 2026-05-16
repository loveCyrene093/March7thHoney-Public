using System;
using March7thHoney.Enums.Mission;

namespace March7thHoney.GameServer.Game.Mission.FinishAction;

[AttributeUsage(AttributeTargets.Class)]
public class MissionFinishActionAttribute : Attribute
{
	public FinishActionTypeEnum FinishAction { get; }

	public MissionFinishActionAttribute(FinishActionTypeEnum finishAction)
	{
		FinishAction = finishAction;
		base._002Ector();
	}
}
