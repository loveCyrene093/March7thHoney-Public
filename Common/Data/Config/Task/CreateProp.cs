using System.Collections.Generic;

namespace March7thHoney.Data.Config.Task;

public class CreateProp : TaskConfigInfo
{
	public DynamicFloat GroupID { get; set; } = new DynamicFloat();

	public DynamicFloat GroupPropID { get; set; } = new DynamicFloat();

	public List<GroupEntityInfo> CreateList { get; set; } = new List<GroupEntityInfo>();
}
