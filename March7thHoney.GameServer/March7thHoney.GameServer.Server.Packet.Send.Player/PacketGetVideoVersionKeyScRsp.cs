using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Custom;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketGetVideoVersionKeyScRsp : BasePacket
{
	public PacketGetVideoVersionKeyScRsp()
		: base(68)
	{
		GetVideoVersionKeyScRsp data = new GetVideoVersionKeyScRsp
		{
			ActivityVideoKeyInfoList = { GameData.VideoKeysConfig.ActivityVideoKeyData.Select((ActivityVideoKeyInfoList activity) => new VideoKeyInfo
			{
				Id = (uint)activity.Id,
				VideoKey = activity.VideoKey
			}) },
			VideoKeyInfoList = { GameData.VideoKeysConfig.VideoKeyInfoData.Select((VideoKeyInfoList video) => new VideoKeyInfo
			{
				Id = (uint)video.Id,
				VideoKey = video.VideoKey
			}) }
		};
		SetData(data);
	}
}
