using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data.Config.SummonUnit;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Scene.Entity;

public class EntitySummonUnit : BaseGameEntity
{
	public int CreateAvatarEntityId { get; set; }

	public int AttachEntityId { get; set; }

	public int CreateAvatarId { get; set; }

	public long CreateTimeMs { get; set; } = Extensions.GetUnixMs();

	public int LifeTimeMs { get; set; } = -1;

	public int SummonUnitId { get; set; }

	public MotionInfo Motion { get; set; } = new MotionInfo();

	public List<UnitCustomTriggerConfigInfo> TriggerList { get; set; } = new List<UnitCustomTriggerConfigInfo>();

	public HashSet<int> CaughtEntityIds { get; set; } = new HashSet<int>();

	public override int EntityId { get; set; }

	public override int GroupId { get; set; }

	public override SceneEntityInfo ToProto()
	{
		return new SceneEntityInfo
		{
			EntityId = (uint)EntityId,
			GroupId = (uint)GroupId,
			Motion = Motion,
			SummonUnit = new SceneSummonUnitInfo
			{
				CasterEntityId = (uint)CreateAvatarEntityId,
				AttachEntityId = (uint)AttachEntityId,
				CreateTimeMs = (ulong)CreateTimeMs,
				LifeTimeMs = LifeTimeMs,
				SummonUnitId = (uint)SummonUnitId,
				TriggerNameList = { TriggerList.Select((UnitCustomTriggerConfigInfo x) => x.TriggerName) }
			}
		};
	}
}
