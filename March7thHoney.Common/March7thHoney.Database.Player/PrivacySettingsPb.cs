using March7thHoney.Proto;

namespace March7thHoney.Database.Player;

public class PrivacySettingsPb
{
	public bool DisplayChallengeLineup { get; set; } = true;

	public bool DisplayActiveState { get; set; } = true;

	public bool DisplayRecentlyState { get; set; } = true;

	public bool DisplayBattleRecord { get; set; } = true;

	public bool DisplayCollection { get; set; } = true;

	public PlayerSettingInfo ToSettingProto()
	{
		return new PlayerSettingInfo
		{
			COIGOCJHBOP = DisplayChallengeLineup,
			CHCNEDNCIDJ = DisplayActiveState,
			LPEPIDNJDEM = DisplayRecentlyState,
			BKDCFBDMNIJ = DisplayBattleRecord,
			PFJMEECGJMM = DisplayCollection
		};
	}
}
