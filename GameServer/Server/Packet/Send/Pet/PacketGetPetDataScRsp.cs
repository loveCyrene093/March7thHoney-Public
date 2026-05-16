using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Pet;

public class PacketGetPetDataScRsp : BasePacket
{
	public PacketGetPetDataScRsp(PlayerInstance player)
		: base(7604)
	{
		GetPetDataScRsp getPetDataScRsp = new GetPetDataScRsp
		{
			CurPetId = (uint)player.Data.Pet
		};
		foreach (PetExcel value in GameData.PetData.Values)
		{
			getPetDataScRsp.UnlockedPetId.Add((uint)value.PetID);
		}
		SetData(getPetDataScRsp);
	}
}
