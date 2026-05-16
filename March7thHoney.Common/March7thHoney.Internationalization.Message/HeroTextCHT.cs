namespace March7thHoney.Internationalization.Message;

public class HeroTextCHT
{
	public string Desc => "切換主角的性別/形態\n當切換性別時，genderId為1代表男性，2代表女性\n當切換形態時，8001代表毀滅命途，8003代表存護命途，8005代表同諧命途。\n注意，切換性別時會清空所有可選命途以及行跡，為不可逆操作！";

	public string Usage => "用法：/hero gender [genderId]\n\n用法：/hero type [typeId]";

	public string GenderNotSpecified => "性別不存在!";

	public string HeroTypeNotSpecified => "主角類型不存在!";

	public string GenderChanged => "性別已更改!";

	public string HeroTypeChanged => "主角類型已更改!";
}
