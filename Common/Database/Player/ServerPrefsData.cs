using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Player;

[SugarTable("server_prefs_data")]
public class ServerPrefsData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public Dictionary<int, ServerPrefsInfo> ServerPrefsDict { get; set; } = new Dictionary<int, ServerPrefsInfo>();

	public double Version { get; set; } = 3.2;

	public void SetData(int prefsId, string b64Data)
	{
		ServerPrefsDict[prefsId] = new ServerPrefsInfo
		{
			ServerPrefsId = prefsId,
			Data = b64Data
		};
	}
}
