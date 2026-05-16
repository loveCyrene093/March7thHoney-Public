using System;
using Google.Protobuf;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.Database.Scene;

public class SwitchHandInfo
{
	public int ConfigId { get; set; }

	public int CoinNum { get; set; }

	public Position Pos { get; set; } = new Position();

	public Position Rot { get; set; } = new Position();

	public uint State { get; set; } = 101u;

	public byte[] ByteValue { get; set; } = Array.Empty<byte>();

	public GODHDEIPDJL ToProto()
	{
		return new GODHDEIPDJL
		{
			ConfigId = (uint)ConfigId,
			MHINKADJCCG = ByteString.CopyFrom(ByteValue),
			AMBLLFLFKHC = (uint)CoinNum,
			PLFAOCPBBCP = new MotionInfo
			{
				Pos = Pos.ToProto(),
				Rot = Rot.ToProto()
			},
			JLMJFEDNBMF = State
		};
	}
}
