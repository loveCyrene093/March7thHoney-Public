using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBasicInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBasicInfoScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChdHZXRCYXNpY0luZm9TY1JzcC5wcm90bxoXUGxheWVyU2V0dGluZ0luZm8u";
		buffer[1] = "cHJvdG8inwIKEUdldEJhc2ljSW5mb1NjUnNwEhUKDWlzX2dlbmRlcl9zZXQY";
		buffer[2] = "AiABKAgSDgoGZ2VuZGVyGAQgASgNEi8KE3BsYXllcl9zZXR0aW5nX2luZm8Y";
		buffer[3] = "BSABKAsyEi5QbGF5ZXJTZXR0aW5nSW5mbxIPCgdjdXJfZGF5GAcgASgNEhkK";
		buffer[4] = "EW5leHRfcmVjb3Zlcl90aW1lGAggASgDEhkKEWdhbWVwbGF5X2JpcnRoZGF5";
		buffer[5] = "GAogASgNEiIKGndlZWtfY29jb29uX2ZpbmlzaGVkX2NvdW50GAsgASgNEhYK";
		buffer[6] = "DmV4Y2hhbmdlX3RpbWVzGAwgASgNEg8KB3JldGNvZGUYDSABKA0SHgoWbGFz";
		buffer[7] = "dF9zZXRfbmlja25hbWVfdGltZRgOIAEoA0IWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[8] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PlayerSettingInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBasicInfoScRsp), GetBasicInfoScRsp.Parser, new string[10] { "IsGenderSet", "Gender", "PlayerSettingInfo", "CurDay", "NextRecoverTime", "GameplayBirthday", "WeekCocoonFinishedCount", "ExchangeTimes", "Retcode", "LastSetNicknameTime" }, null, null, null, null)
		}));
	}
}
