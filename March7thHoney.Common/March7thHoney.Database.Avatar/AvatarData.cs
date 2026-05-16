using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Avatar;

[SugarTable("Avatar")]
public class AvatarData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public List<OldAvatarInfo> Avatars { get; set; } = new List<OldAvatarInfo>();

	[SugarColumn(IsJson = true)]
	public List<FormalAvatarInfo> FormalAvatars { get; set; } = new List<FormalAvatarInfo>();

	[SugarColumn(IsJson = true)]
	public List<SpecialAvatarInfo> TrialAvatars { get; set; } = new List<SpecialAvatarInfo>();

	[SugarColumn(IsJson = true)]
	public List<int> AssistAvatars { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public List<int> DisplayAvatars { get; set; } = new List<int>();

	public string DatabaseVersion { get; set; } = "0";
}
