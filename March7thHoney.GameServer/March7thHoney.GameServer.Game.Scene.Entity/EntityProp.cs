using System.Threading.Tasks;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Scene;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Scene.Entity;

public class EntityProp : BaseGameEntity
{
	public Position Position { get; set; }

	public Position Rotation { get; set; }

	public SceneInstance Scene { get; set; }

	public PropStateEnum State { get; set; }

	public int InstId { get; set; }

	public MazePropExcel Excel { get; set; }

	public PropInfo PropInfo { get; set; }

	public GroupInfo Group { get; set; }

	public ScenePropTimelineData? PropTimelineData { get; set; }

	public override int EntityId { get; set; }

	public override int GroupId { get; set; }

	public EntityProp(SceneInstance scene, MazePropExcel excel, GroupInfo group, PropInfo prop)
	{
		Position = prop.ToPositionProto();
		Rotation = prop.ToRotationProto();
		Scene = scene;
		InstId = prop.ID;
		Excel = excel;
		PropInfo = prop;
		Group = group;
		GroupId = group.Id;
		base._002Ector();
	}

	public override SceneEntityInfo ToProto()
	{
		ScenePropInfo scenePropInfo = new ScenePropInfo
		{
			PropId = (uint)Excel.ID,
			PropState = (uint)State
		};
		if (PropTimelineData != null)
		{
			scenePropInfo.ExtraInfo = new PropExtraInfo
			{
				TimelineInfo = PropTimelineData.ToProto()
			};
		}
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
			Prop = scenePropInfo
		};
	}

	public async ValueTask SetState(PropStateEnum state)
	{
		if (state != State)
		{
			await SetState(state, Scene.IsLoaded);
		}
	}

	public async ValueTask SetState(PropStateEnum state, bool sendPacket)
	{
		State = state;
		if (sendPacket)
		{
			await Scene.Player.SendPacket(new PacketSceneGroupRefreshScNotify(Scene.Player, this, null, SceneGroupRefreshType.Afibfmafncc));
		}
		if (Group.SaveType != SaveTypeEnum.Reset)
		{
			Scene.Player.SetScenePropData(Scene.FloorId, Group.Id, PropInfo.ID, state);
		}
	}
}
