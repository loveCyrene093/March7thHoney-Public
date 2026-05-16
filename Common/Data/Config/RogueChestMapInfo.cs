using System.Collections.Generic;

namespace March7thHoney.Data.Config;

public class RogueChestMapInfo
{
	public List<int> PreStartRoomIDList { get; set; } = new List<int>();

	public int Width { get; set; }

	public int Height { get; set; }

	public int StartGridItemID { get; set; }

	public int EndGridItemID { get; set; }

	public Dictionary<int, RogueChestGridItem> RogueChestGridItemMap { get; set; } = new Dictionary<int, RogueChestGridItem>();

	public Dictionary<int, RogueChestModifierEvent> RogueChestEventMap { get; set; } = new Dictionary<int, RogueChestModifierEvent>();

	public List<RogueBlockCreateGroup> RogueBlockCreateGroupList { get; set; } = new List<RogueBlockCreateGroup>();
}
