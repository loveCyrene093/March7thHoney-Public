using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.RechargeGift;

public class PacketGetRechargeGiftInfoScRsp : BasePacket
{
	public PacketGetRechargeGiftInfoScRsp()
		: base(8380)
	{
		GetRechargeGiftInfoScRsp data = new GetRechargeGiftInfoScRsp
		{
			FEKLJCAOGII = 
			{
				new ABIPCNKGFNI
				{
					DNNHCNCKJCM = 1777112805L,
					EndTime = 1777976805L,
					GiftType = 16u,
					FLHLJMEMIHL = 
					{
						new PPPFOMBLOIF
						{
							Status = BNDHJNDFFED.Amjcmcjdpkd
						},
						new PPPFOMBLOIF
						{
							Index = 2u,
							Status = BNDHJNDFFED.Amjcmcjdpkd
						},
						new PPPFOMBLOIF
						{
							Index = 3u,
							Status = BNDHJNDFFED.Amjcmcjdpkd
						},
						new PPPFOMBLOIF
						{
							Index = 4u,
							Status = BNDHJNDFFED.Amjcmcjdpkd
						},
						new PPPFOMBLOIF
						{
							Index = 5u,
							Status = BNDHJNDFFED.Amjcmcjdpkd
						}
					}
				}
			}
		};
		SetData(data);
	}
}
