using March7thHoney.Data.Config.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Scene.Entity;

public class EntityNpc : BaseGameEntity
{
	public SceneInstance Scene { get; set; }

	public Position Position { get; set; }

	public Position Rotation { get; set; }

	public int NpcId { get; set; }

	public int InstId { get; set; }

	public override int EntityId { get; set; }

	public override int GroupId { get; set; }

	public EntityNpc(SceneInstance scene, GroupInfo group, NpcInfo npcInfo)
	{
		Scene = scene;
		Position = npcInfo.ToPositionProto();
		Rotation = npcInfo.ToRotationProto();
		NpcId = npcInfo.NPCID;
		InstId = npcInfo.ID;
		GroupId = group.Id;
		base._002Ector();
	}

	public override SceneEntityInfo ToProto()
	{
		SceneNpcInfo npc = new SceneNpcInfo
		{
			NpcId = (uint)NpcId
		};
		return new SceneEntityInfo
		{
			EntityId = (uint)EntityId,
			GroupId = (uint)GroupId,
			Motion = new MotionInfo
			{
				Pos = Position.ToProto(),
				Rot = Rotation.ToProto()
			},
			InstId = (uint)InstId,
			Npc = npc
		};
	}
}
