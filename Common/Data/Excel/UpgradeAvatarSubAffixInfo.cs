using March7thHoney.Enums.Avatar;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

public class UpgradeAvatarSubAffixInfo
{
	[JsonProperty("KHADHNNCFLH")]
	public uint AffixCount { get; set; }

	[JsonProperty("LKOEFDPJGKD")]
	[JsonConverter(typeof(StringEnumConverter))]
	public AvatarPropertyTypeEnum AffixProperty { get; set; }
}
