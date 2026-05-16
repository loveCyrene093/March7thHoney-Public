namespace March7thHoney.Enums;

public static class GachaTypeEnumExtensions
{
	public static int GetCostItemId(this GachaTypeEnum type)
	{
		switch (type)
		{
		case GachaTypeEnum.Newbie:
		case GachaTypeEnum.Normal:
			return 101;
		case GachaTypeEnum.AvatarUp:
		case GachaTypeEnum.WeaponUp:
			return 102;
		default:
			return 0;
		}
	}
}
