using System.Collections.Generic;
using System.Runtime.InteropServices;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketSceneGroupRefreshScNotify : BasePacket
{
	public PacketSceneGroupRefreshScNotify(PlayerInstance player, List<BaseGameEntity>? addEntity = null, List<BaseGameEntity>? removeEntity = null, SceneGroupRefreshType refreshType = SceneGroupRefreshType.Loaded)
		: base(1455)
	{
		if (refreshType == SceneGroupRefreshType.Loaded && removeEntity != null && removeEntity.Count > 0)
		{
			refreshType = SceneGroupRefreshType.Afibfmafncc;
		}
		SceneGroupRefreshScNotify sceneGroupRefreshScNotify = new SceneGroupRefreshScNotify
		{
			FloorId = (uint)player.Data.FloorId,
			DimensionId = (uint)player.SceneInstance.ResolveDimensionId()
		};
		Dictionary<int, GroupRefreshInfo> dictionary = new Dictionary<int, GroupRefreshInfo>();
		foreach (BaseGameEntity item in removeEntity ?? new List<BaseGameEntity>())
		{
			GroupRefreshInfo groupRefreshInfo = new GroupRefreshInfo
			{
				GroupId = (uint)item.GroupId,
				RefreshType = refreshType
			};
			groupRefreshInfo.RefreshEntity.Add(new SceneEntityRefreshInfo
			{
				DeleteEntity = (uint)item.EntityId
			});
			if (dictionary.TryGetValue(item.GroupId, out var value))
			{
				value.RefreshEntity.AddRange(groupRefreshInfo.RefreshEntity);
			}
			else
			{
				dictionary[item.GroupId] = groupRefreshInfo;
			}
		}
		foreach (BaseGameEntity item2 in addEntity ?? new List<BaseGameEntity>())
		{
			GroupRefreshInfo groupRefreshInfo2 = new GroupRefreshInfo
			{
				GroupId = (uint)item2.GroupId,
				RefreshType = refreshType
			};
			groupRefreshInfo2.RefreshEntity.Add(new SceneEntityRefreshInfo
			{
				AddEntity = item2.ToProto()
			});
			if (dictionary.TryGetValue(item2.GroupId, out var value2))
			{
				value2.RefreshEntity.AddRange(groupRefreshInfo2.RefreshEntity);
			}
			else
			{
				dictionary[item2.GroupId] = groupRefreshInfo2;
			}
		}
		sceneGroupRefreshScNotify.GroupRefreshList.AddRange(dictionary.Values);
		SetData(sceneGroupRefreshScNotify);
	}

	public PacketSceneGroupRefreshScNotify(PlayerInstance player, BaseGameEntity? addEntity = null, BaseGameEntity? removeEntity = null, SceneGroupRefreshType refreshType = SceneGroupRefreshType.Loaded)
	{
		List<BaseGameEntity> list;
		if (addEntity != null)
		{
			int num = 1;
			list = new List<BaseGameEntity>(num);
			CollectionsMarshal.SetCount(list, num);
			CollectionsMarshal.AsSpan(list)[0] = addEntity;
		}
		else
		{
			list = new List<BaseGameEntity>();
		}
		List<BaseGameEntity> list2;
		if (removeEntity != null)
		{
			int num = 1;
			list2 = new List<BaseGameEntity>(num);
			CollectionsMarshal.SetCount(list2, num);
			CollectionsMarshal.AsSpan(list2)[0] = removeEntity;
		}
		else
		{
			list2 = new List<BaseGameEntity>();
		}
		this._002Ector(player, list, list2, refreshType);
	}

	public PacketSceneGroupRefreshScNotify(SceneInstance scene, List<GroupPropertyRefreshData> refreshDataList)
		: base(1455)
	{
		SceneGroupRefreshScNotify sceneGroupRefreshScNotify = new SceneGroupRefreshScNotify
		{
			FloorId = (uint)scene.FloorId,
			DimensionId = (uint)scene.ResolveDimensionId()
		};
		Dictionary<int, List<GroupPropertyRefreshData>> dictionary = new Dictionary<int, List<GroupPropertyRefreshData>>();
		foreach (GroupPropertyRefreshData refreshData in refreshDataList)
		{
			if (!dictionary.TryGetValue(refreshData.GroupId, out var value))
			{
				value = new List<GroupPropertyRefreshData>();
				dictionary[refreshData.GroupId] = value;
			}
			value.Add(refreshData);
		}
		foreach (KeyValuePair<int, List<GroupPropertyRefreshData>> item in dictionary)
		{
			item.Deconstruct(out var key, out var value2);
			int groupId = key;
			List<GroupPropertyRefreshData> list = value2;
			GroupRefreshInfo groupRefreshInfo = new GroupRefreshInfo
			{
				GroupId = (uint)groupId,
				RefreshType = SceneGroupRefreshType.Loaded
			};
			foreach (GroupPropertyRefreshData item2 in list)
			{
				groupRefreshInfo.DCLAKCFJCPJ.Add(new NNHGOBLNCIE
				{
					ELKOCIJNABK = item2.NewValue,
					FNAODNGJAMM = item2.OldValue,
					ELNCJFFJFIH = item2.PropertyName
				});
			}
			sceneGroupRefreshScNotify.GroupRefreshList.Add(groupRefreshInfo);
		}
		SetData(sceneGroupRefreshScNotify);
	}
}
