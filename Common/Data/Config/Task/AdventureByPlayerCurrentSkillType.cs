using March7thHoney.Enums.Avatar;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Task;

public class AdventureByPlayerCurrentSkillType : PredicateConfigInfo
{
	[JsonConverter(typeof(StringEnumConverter))]
	public AdventureSkillTypeEnum SkillType { get; set; }
}
