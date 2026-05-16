using System.Collections.Generic;

namespace March7thHoney.Data.Config.Task;

public class DestroyProp : TaskConfigInfo
{
	public DynamicFloat ID { get; set; } = new DynamicFloat();

	public DynamicFloat GroupID { get; set; } = new DynamicFloat();

	public List<GroupEntityInfo> DestroyList { get; set; } = new List<GroupEntityInfo>();
}
