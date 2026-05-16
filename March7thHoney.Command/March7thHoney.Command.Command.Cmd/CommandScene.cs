using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using March7thHoney.Database.Scene;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Internationalization;
using March7thHoney.Util;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("scene", "Game.Command.Scene.Desc", "Game.Command.Scene.Usage", "", "")]
public class CommandScene : ICommand
{
	[CommandMethod("0 group")]
	public async ValueTask GetLoadedGroup(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		SceneInstance? sceneInstance = arg.Target.Player.SceneInstance;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, BaseGameEntity> entity in sceneInstance.Entities)
		{
			if (!list.Contains(entity.Value.GroupId))
			{
				list.Add(entity.Value.GroupId);
			}
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.LoadedGroups", string.Join(", ", list)));
	}

	[CommandMethod("0 prop")]
	public async ValueTask GetProp(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		SceneInstance? sceneInstance = arg.Target.Player.SceneInstance;
		EntityProp prop = null;
		foreach (EntityProp item in sceneInstance.GetEntitiesInGroup<EntityProp>(arg.GetInt(0)))
		{
			if (item.PropInfo.ID == arg.GetInt(1))
			{
				prop = item;
				break;
			}
		}
		if (prop == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.PropNotFound"));
			return;
		}
		await prop.SetState((PropStateEnum)arg.GetInt(2));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.PropStateChanged", prop.PropInfo.ID.ToString(), prop.State.ToString()));
	}

	[CommandMethod("0 remove")]
	public async ValueTask RemoveEntity(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		SceneInstance sceneInstance = arg.Target.Player.SceneInstance;
		sceneInstance.Entities.TryGetValue(arg.GetInt(0), out BaseGameEntity entity);
		if (entity == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.EntityNotFound"));
			return;
		}
		await sceneInstance.RemoveEntity(entity);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.EntityRemoved", entity.EntityId.ToString()));
	}

	[CommandMethod("0 unlockall")]
	public async ValueTask UnlockAll(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		SceneInstance sceneInstance = arg.Target.Player.SceneInstance;
		foreach (BaseGameEntity value in sceneInstance.Entities.Values)
		{
			if (value is EntityProp entityProp && entityProp.Excel.PropStateList.Contains(PropStateEnum.Open))
			{
				await entityProp.SetState(PropStateEnum.Open);
			}
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.AllPropsUnlocked"));
	}

	[CommandMethod("0 unlockallgroup")]
	public async ValueTask UnlockAllGroup(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		SceneInstance scene = arg.Target.Player.SceneInstance;
		foreach (int group in scene.Groups)
		{
			await scene.UpdateGroupProperty(group, "Lock", 0);
		}
		foreach (int group2 in scene.Groups)
		{
			await scene.UpdateGroupProperty(group2, "PlateArrived", 2);
		}
		if (arg.Target.Player.SceneInstance.FloorId == 20431001)
		{
			string text = "FSV_EnvLight";
			int num = 5;
			if (arg.Target.Player.SceneData.FloorSavedData.TryGetValue(arg.Target.Player.SceneInstance.FloorId, out Dictionary<string, int> value))
			{
				value[text] = num;
			}
			else
			{
				arg.Target.Player.SceneData.FloorSavedData[arg.Target.Player.SceneInstance.FloorId] = new Dictionary<string, int> { { text, num } };
			}
			await arg.Target.Player.SendPacket(new PacketUpdateFloorSavedValueNotify(text, num, arg.Target.Player));
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.AllPropsUnlocked"));
	}

	[CommandMethod("0 change")]
	public async ValueTask ChangeScene(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.GetInt(0) == 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		await arg.Target.Player.EnterScene(arg.GetInt(0), 0, sendPacket: true);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.SceneChanged", arg.GetInt(0).ToString()));
	}

	[CommandMethod("0 reload")]
	public async ValueTask ReloadScene(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance? player = arg.Target.Player;
		await player.EnterScene(player.Data.EntryId, 0, sendPacket: true);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.SceneReloaded"));
	}

	[CommandMethod("0 reset")]
	public async ValueTask ResetFloor(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		int num = arg.GetInt(0);
		if (num == 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		if (player.SceneData?.ScenePropData.TryGetValue(num, out Dictionary<int, List<ScenePropData>> _) ?? false)
		{
			player.SceneData.ScenePropData[num] = new Dictionary<int, List<ScenePropData>>();
		}
		if (player.SceneData?.FloorSavedData.TryGetValue(num, out Dictionary<string, int> _) ?? false)
		{
			player.SceneData.FloorSavedData[num] = new Dictionary<string, int>();
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.SceneReset", num.ToString()));
	}

	[CommandMethod("0 fsv")]
	public async ValueTask SetFSV(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.Args.Count < 3)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		string name = arg.Args[1];
		int value = int.Parse(arg.Args[2]);
		await arg.Target.Player.SceneInstance.UpdateFloorSavedValue(name, value);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.FSVSet", name, value.ToString()));
	}

	[CommandMethod("0 gp")]
	public async ValueTask SetGP(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.Args.Count < 4)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		string name = arg.Args[2];
		int value = int.Parse(arg.Args[3]);
		int groupId = int.Parse(arg.Args[1]);
		await arg.Target.Player.SceneInstance.UpdateGroupProperty(groupId, name, value);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.FSVSet", name, value.ToString()));
	}

	[CommandMethod("0 cur")]
	public async ValueTask GetCurrentScene(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		await arg.SendMsg(I18NManager.Translate("Game.Command.Scene.CurrentScene", player.Data.EntryId.ToString(), player.Data.PlaneId.ToString(), player.Data.FloorId.ToString()));
	}

	[CommandMethod("0 near")]
	public async ValueTask GetNearestProp(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		long num = 1000000000L;
		EntityProp entityProp = null;
		foreach (EntityProp item in player.SceneInstance.Entities.Values.OfType<EntityProp>())
		{
			long fast2dDist = item.Position.GetFast2dDist(player.Data.Pos);
			if (fast2dDist < num)
			{
				entityProp = item;
				num = fast2dDist;
			}
		}
		if (entityProp != null)
		{
			await arg.SendMsg($"Nearest Prop {entityProp.EntityId}: PropId {entityProp.PropInfo.ID}, GroupId {entityProp.GroupId}, State {entityProp.State}");
		}
	}

	[CommandMethod("0 forward")]
	public async ValueTask Teleport(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count == 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		int num = arg.GetInt(0);
		PlayerInstance player = arg.Target.Player;
		Vector3 vector = new Vector3(player.Data.Pos.X, player.Data.Pos.Y, player.Data.Pos.Z);
		Vector3 vector2 = Vector3.Normalize(new Vector3(player.Data.Rot.X, player.Data.Rot.Y, player.Data.Rot.Z));
		vector += vector2 * num;
		await player.MoveTo(new Position((int)vector.X, (int)vector.Y, (int)vector.Z));
		await arg.SendMsg("Teleported!");
	}
}
