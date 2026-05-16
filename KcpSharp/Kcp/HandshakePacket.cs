using System;
using Google.Protobuf;
using March7thHoney.Proto;

namespace March7thHoney.Kcp;

public class HandshakePacket : BasePacket
{
	public HandshakePacket(byte[] data)
		: base(11)
	{
		ClientDownloadData downloadData = new ClientDownloadData
		{
			Data = ByteString.CopyFrom(data),
			Version = 81u,
			Time = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds
		};
		ClientDownloadDataScNotify data2 = new ClientDownloadDataScNotify
		{
			DownloadData = downloadData
		};
		SetData(data2);
	}

	public HandshakePacket(string base64)
		: base(11)
	{
		SetData(Convert.FromBase64String(base64));
	}
}
