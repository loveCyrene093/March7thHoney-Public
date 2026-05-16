namespace March7thHoney.Internationalization.Message;

public class HeroTextCHS
{
	public string Desc => "切换主角的性别/形态\n当切换性别时，genderId为1代表男性，2代表女性\n当切换形态时，8001代表毁灭命途，8003代表存护命途，8005代表同谐命途。\n注意，切换性别时会清空所有可选命途以及行迹，为不可逆操作！";

	public string Usage => "用法：/hero gender [genderId]\n\n用法：/hero type [typeId]";

	public string GenderNotSpecified => "性别不存在!";

	public string HeroTypeNotSpecified => "主角类型不存在!";

	public string GenderChanged => "性别已更改!";

	public string HeroTypeChanged => "主角类型已更改!";
}
