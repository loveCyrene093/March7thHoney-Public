using System;
using System.IO;
using Google.Protobuf;
using March7thHoney.Util;

namespace March7thHoney.Kcp;

public class BasePacket
{
	private const uint HEADER_CONST = 2641676052u;

	private const uint TAIL_CONST = 3617673928u;

	public ushort CmdId { get; set; }

	public byte[] Data { get; set; }

	public BasePacket(ushort cmdId)
	{
		CmdId = cmdId;
		Data = Array.Empty<byte>();
		base._002Ector();
	}

	public void SetData(byte[] data)
	{
		Data = data;
	}

	public void SetData(IMessage message)
	{
		Data = message.ToByteArray();
	}

	public void SetData(string base64)
	{
		SetData(Convert.FromBase64String(base64));
	}

	public byte[] BuildPacket()
	{
		using MemoryStream memoryStream = new MemoryStream();
		using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.WriteUInt32BE(2641676052u);
		binaryWriter.WriteUInt16BE(CmdId);
		binaryWriter.WriteUInt16BE(0);
		binaryWriter.WriteUInt32BE((uint)Data.Length);
		if (Data.Length != 0)
		{
			binaryWriter.Write(Data);
		}
		binaryWriter.WriteUInt32BE(3617673928u);
		return memoryStream.ToArray();
	}
}
