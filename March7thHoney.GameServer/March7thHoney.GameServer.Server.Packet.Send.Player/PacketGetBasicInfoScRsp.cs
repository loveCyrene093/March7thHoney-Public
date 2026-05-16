using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketGetBasicInfoScRsp : BasePacket
{
	public PacketGetBasicInfoScRsp(PlayerInstance player)
		: base(36)
	{
		GetBasicInfoScRsp getBasicInfoScRsp = new GetBasicInfoScRsp
		{
			CurDay = 1u,
			NextRecoverTime = player.Data.NextStaminaRecover / 1000,
			GameplayBirthday = (uint)player.Data.Birthday,
			PlayerSettingInfo = player.Data.PrivacySettings.ToSettingProto(),
			Gender = (uint)player.Data.CurrentGender
		};
		if (ConfigManager.Config.ServerOption.EnableMission)
		{
			if (player.AvatarManager.GetHero().PathInfos.Count > 0)
			{
				player.Data.IsGenderSet = true;
			}
			getBasicInfoScRsp.Gender = (uint)player.Data.CurrentGender;
			getBasicInfoScRsp.IsGenderSet = player.Data.IsGenderSet;
		}
		else
		{
			getBasicInfoScRsp.Gender = (uint)player.Data.CurrentGender;
			getBasicInfoScRsp.IsGenderSet = true;
		}
		SetData(getBasicInfoScRsp);
	}
}
