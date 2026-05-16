using Google.Protobuf;
using March7thHoney.Proto;

namespace March7thHoney.Database.Player;

public class ServerPrefsInfo
{
	public int ServerPrefsId { get; set; }

	public string Data { get; set; } = "";

	public ServerPrefs ToProto()
	{
		return new ServerPrefs
		{
			Data = ByteString.FromBase64(Data),
			ServerPrefsId = (uint)ServerPrefsId
		};
	}
}
