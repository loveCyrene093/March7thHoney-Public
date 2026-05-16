using March7thHoney.Enums.Avatar;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

public class AvatarRelicRecommendMainAffix
{
	[JsonConverter(typeof(StringEnumConverter))]
	public RelicTypeEnum RelicType { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public AvatarPropertyTypeEnum PropertyType { get; set; }
}
