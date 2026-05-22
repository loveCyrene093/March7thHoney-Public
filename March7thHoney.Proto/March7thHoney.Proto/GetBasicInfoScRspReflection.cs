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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChdHZXRCYXNpY0luZm9TY1JzcC5wcm90bxoXUGxheWVyU2V0dGluZ0luZm8u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "cHJvdG8inwIKEUdldEJhc2ljSW5mb1NjUnNwEhUKDWlzX2dlbmRlcl9zZXQY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "AiABKAgSDgoGZ2VuZGVyGAQgASgNEi8KE3BsYXllcl9zZXR0aW5nX2luZm8Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "BSABKAsyEi5QbGF5ZXJTZXR0aW5nSW5mbxIPCgdjdXJfZGF5GAcgASgNEhkK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "EW5leHRfcmVjb3Zlcl90aW1lGAggASgDEhkKEWdhbWVwbGF5X2JpcnRoZGF5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "GAogASgNEiIKGndlZWtfY29jb29uX2ZpbmlzaGVkX2NvdW50GAsgASgNEhYK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "DmV4Y2hhbmdlX3RpbWVzGAwgASgNEg8KB3JldGNvZGUYDSABKA0SHgoWbGFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "dF9zZXRfbmlja25hbWVfdGltZRgOIAEoA0IWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[1] { PlayerSettingInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBasicInfoScRsp), GetBasicInfoScRsp.Parser, new string[10] { "IsGenderSet", "Gender", "PlayerSettingInfo", "CurDay", "NextRecoverTime", "GameplayBirthday", "WeekCocoonFinishedCount", "ExchangeTimes", "Retcode", "LastSetNicknameTime" }, null, null, null, null)
		}));
	}
}
