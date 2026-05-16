using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Scene;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Player.Components;

public class SwitchHandComponent : BasePlayerComponent
{
	public int RunningHandConfigId { get; set; }

	public SwitchHandComponent(PlayerInstance player)
		: base(player)
	{
	}

	public List<SwitchHandInfo> GetHandInfos()
	{
		List<SwitchHandInfo> list = new List<SwitchHandInfo>();
		foreach (int key in GameData.MazePuzzleSwitchHandData.Keys)
		{
			(Retcode, SwitchHandInfo) handInfo = GetHandInfo(key);
			if (handInfo.Item2 != null)
			{
				list.Add(handInfo.Item2);
			}
		}
		return list;
	}

	public (Retcode, SwitchHandInfo?) GetHandInfo(int configId)
	{
		MazePuzzleSwitchHandExcel excel = GameData.MazePuzzleSwitchHandData.GetValueOrDefault(configId);
		if (excel == null)
		{
			return (Retcode.RetInteractConfigNotExist, null);
		}
		if (base.Player.SceneData.SwitchHandData.TryGetValue(configId, out SwitchHandInfo value))
		{
			return (Retcode.RetSucc, value);
		}
		value = new SwitchHandInfo
		{
			ConfigId = configId
		};
		FloorInfo floorInfo = GameData.GetFloorInfo(excel.FloorID);
		if (floorInfo == null)
		{
			return (Retcode.RetInteractConfigNotExist, null);
		}
		if (!floorInfo.Groups.TryGetValue(excel.SwitchHandID[0], out GroupInfo value2))
		{
			return (Retcode.RetReqParaInvalid, null);
		}
		PropInfo propInfo = value2.PropList.FirstOrDefault((PropInfo x) => x.ID == excel.SwitchHandID[1]);
		if (propInfo == null)
		{
			return (Retcode.RetReqParaInvalid, null);
		}
		value.Pos = propInfo.ToPositionProto();
		value.Rot = propInfo.ToRotationProto();
		base.Player.SceneData.SwitchHandData[configId] = value;
		return (Retcode.RetSucc, value);
	}

	public (Retcode, SwitchHandInfo?) UpdateHandInfo(GODHDEIPDJL info)
	{
		SwitchHandInfo item = GetHandInfo((int)info.ConfigId).Item2;
		if (item == null)
		{
			return (Retcode.RetInteractConfigNotExist, null);
		}
		item.Pos = info.PLFAOCPBBCP.Pos.ToPosition();
		item.Rot = info.PLFAOCPBBCP.Rot.ToPosition();
		item.State = info.JLMJFEDNBMF;
		item.ByteValue = info.MHINKADJCCG.ToByteArray();
		return (Retcode.RetSucc, item);
	}
}
