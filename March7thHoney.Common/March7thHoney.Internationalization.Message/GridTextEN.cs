namespace March7thHoney.Internationalization.Message;

public class GridTextEN
{
	public string Desc => "Manage Aetherium War content. Note: This part is not yet fully developed. Please report any issues promptly.\nThis command may not check if IDs exist. If it has no effect, please check if parameters are correct.";

	public string Usage => "Usage: /grid gold [Gold Amount]\n\nUsage: /grid role [RoleID] [Role Star]\n\nUsage: /grid equip [EquipmentID]\n\nUsage: /grid consumable [ConsumableID]\n\nUsage: /grid orb [OrbID]";

	public string NotInGame => "Not in Aetherium War!";

	public string InvalidRole => "Role ID or Star does not exist!";

	public string AddedRole => "Role added.";

	public string UpdateGold => "Gained {0} Gold.";

	public string AddEquipment => "Added {0} equipment.";

	public string AddOrb => "Added {0} orb.";

	public string AddConsumable => "Added {0} consumable.";

	public string EnterSection => "Entered {0}-{1}.";
}
