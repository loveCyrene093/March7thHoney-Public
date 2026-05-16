using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ContentPackage;

public class PacketContentPackageGetDataScRsp : BasePacket
{
	public PacketContentPackageGetDataScRsp()
		: base(7507)
	{
		ContentPackageGetDataScRsp data = new ContentPackageGetDataScRsp
		{
			Data = new ContentPackageData
			{
				ContentPackageList = { GameData.ContentPackageConfigData.Select<KeyValuePair<int, ContentPackageConfigExcel>, ContentPackageInfo>((KeyValuePair<int, ContentPackageConfigExcel> x) => new ContentPackageInfo
				{
					ContentId = (uint)x.Key,
					Status = ContentPackageStatus.Finished
				}) }
			}
		};
		SetData(data);
	}
}
