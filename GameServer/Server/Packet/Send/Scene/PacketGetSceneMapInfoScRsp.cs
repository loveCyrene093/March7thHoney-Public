using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketGetSceneMapInfoScRsp : BasePacket
{
	public PacketGetSceneMapInfoScRsp(GetSceneMapInfoCsReq req, PlayerInstance player)
		: base(1499)
	{
		GetSceneMapInfoScRsp getSceneMapInfoScRsp = new GetSceneMapInfoScRsp();
		foreach (SceneIdentifier sceneIdentifier in req.SceneIdentifiers)
		{
			uint floorId = sceneIdentifier.FloorId;
			SceneMapInfo sceneMapInfo = new SceneMapInfo
			{
				FloorId = floorId,
				SceneIdentifier = new SceneIdentifier
				{
					FloorId = floorId
				}
			};
			List<MapEntranceExcel> list = GameData.MapEntranceData.Values.Where((MapEntranceExcel x) => x.FloorID == floorId).ToList();
			if (list.Count == 0)
			{
				getSceneMapInfoScRsp.SceneMapInfo.Add(sceneMapInfo);
				continue;
			}
			MapEntranceExcel mapEntranceExcel = list.RandomElement();
			GameData.GetFloorInfo(mapEntranceExcel.PlaneID, mapEntranceExcel.FloorID, out FloorInfo outer);
			if (outer == null)
			{
				getSceneMapInfoScRsp.SceneMapInfo.Add(sceneMapInfo);
				continue;
			}
			sceneMapInfo.ChestList.Add(new ChestInfo
			{
				ExistNum = 1u,
				ChestType = ChestType.MapInfoChestTypeNormal
			});
			sceneMapInfo.ChestList.Add(new ChestInfo
			{
				ExistNum = 1u,
				ChestType = ChestType.MapInfoChestTypePuzzle
			});
			sceneMapInfo.ChestList.Add(new ChestInfo
			{
				ExistNum = 1u,
				ChestType = ChestType.MapInfoChestTypeChallenge
			});
			if (player.SceneInstance?.FloorId == floorId)
			{
				foreach (int item2 in player.SceneInstance.Groups.Distinct())
				{
					sceneMapInfo.MazeGroupList.Add(new MazeGroup
					{
						GroupId = (uint)item2
					});
				}
			}
			else
			{
				foreach (GroupInfo value6 in outer.Groups.Values)
				{
					sceneMapInfo.MazeGroupList.Add(new MazeGroup
					{
						GroupId = (uint)value6.Id
					});
				}
			}
			foreach (PropInfo value7 in outer.CachedTeleports.Values)
			{
				sceneMapInfo.UnlockTeleportList.Add((uint)value7.MappingInfoID);
			}
			foreach (PropInfo unlockedCheckpoint in outer.UnlockedCheckpoints)
			{
				MazePropState item = new MazePropState
				{
					GroupId = (uint)unlockedCheckpoint.AnchorGroupID,
					ConfigId = (uint)unlockedCheckpoint.ID,
					State = 8u
				};
				sceneMapInfo.MazePropList.Add(item);
			}
			int key;
			if (player.SceneData.ScenePropData.TryGetValue((int)floorId, out Dictionary<int, List<ScenePropData>> value))
			{
				foreach (KeyValuePair<int, List<ScenePropData>> item3 in value)
				{
					item3.Deconstruct(out key, out var value2);
					int groupId = key;
					foreach (ScenePropData propData in value2)
					{
						if (!sceneMapInfo.MazePropList.Any((MazePropState x) => x.GroupId == (uint)groupId && x.ConfigId == (uint)propData.PropId))
						{
							sceneMapInfo.MazePropList.Add(new MazePropState
							{
								GroupId = (uint)groupId,
								ConfigId = (uint)propData.PropId,
								State = (uint)propData.State
							});
						}
					}
				}
			}
			if (player.SceneInstance?.FloorId == floorId)
			{
				foreach (EntityProp prop in player.SceneInstance.Entities.Values.OfType<EntityProp>())
				{
					if (!sceneMapInfo.MazePropList.Any((MazePropState x) => x.GroupId == (uint)prop.GroupId && x.ConfigId == (uint)prop.InstId))
					{
						sceneMapInfo.MazePropList.Add(new MazePropState
						{
							GroupId = (uint)prop.GroupId,
							ConfigId = (uint)prop.InstId,
							State = (uint)prop.State
						});
					}
				}
			}
			if (player.SceneData.FloorSavedData.TryGetValue((int)floorId, out Dictionary<string, int> value3))
			{
				foreach (KeyValuePair<string, int> item4 in value3)
				{
					item4.Deconstruct(out var key2, out key);
					string key3 = key2;
					int value4 = key;
					sceneMapInfo.FloorSavedData[key3] = value4;
				}
			}
			if (!ConfigManager.Config.ServerOption.AutoLightSection)
			{
				player.SceneData.UnlockSectionIdList.TryGetValue(mapEntranceExcel.FloorID, out List<int> value5);
				foreach (int item5 in value5 ?? new List<int>())
				{
					sceneMapInfo.LightenSectionList.Add((uint)item5);
				}
			}
			else
			{
				sceneMapInfo.LightenSectionList.AddRange(outer.MapSections.Select((int x) => (uint)x));
			}
			getSceneMapInfoScRsp.SceneMapInfo.Add(sceneMapInfo);
		}
		SetData(getSceneMapInfoScRsp);
	}
}
