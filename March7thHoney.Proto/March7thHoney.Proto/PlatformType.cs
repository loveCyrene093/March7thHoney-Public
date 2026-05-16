using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum PlatformType
{
	[OriginalName("EDITOR")]
	Editor = 0,
	[OriginalName("IOS")]
	Ios = 1,
	[OriginalName("ANDROID")]
	Android = 2,
	[OriginalName("PC")]
	Pc = 3,
	[OriginalName("WEB")]
	Web = 4,
	[OriginalName("WAP")]
	Wap = 5,
	[OriginalName("PS4")]
	Ps4 = 6,
	[OriginalName("NINTENDO")]
	Nintendo = 7,
	[OriginalName("CLOUD_ANDROID")]
	CloudAndroid = 8,
	[OriginalName("CLOUD_PC")]
	CloudPc = 9,
	[OriginalName("CLOUD_IOS")]
	CloudIos = 10,
	[OriginalName("PS5")]
	Ps5 = 11,
	[OriginalName("MAC")]
	Mac = 12,
	[OriginalName("CLOUD_MAC")]
	CloudMac = 13,
	[OriginalName("CLOUD_WEB_ANDROID")]
	CloudWebAndroid = 20,
	[OriginalName("CLOUD_WEB_IOS")]
	CloudWebIos = 21,
	[OriginalName("CLOUD_WEB_PC")]
	CloudWebPc = 22,
	[OriginalName("CLOUD_WEB_MAC")]
	CloudWebMac = 23,
	[OriginalName("CLOUD_WEB_TOUCH")]
	CloudWebTouch = 24,
	[OriginalName("CLOUD_WEB_KEYBOARD")]
	CloudWebKeyboard = 25,
	[OriginalName("CLOUD_DOUYIN_IOS")]
	CloudDouyinIos = 27,
	[OriginalName("CLOUD_DOUYIN_ANDROID")]
	CloudDouyinAndroid = 28
}
