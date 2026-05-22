using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBossAvatarRelicInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBossAvatarRelicInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CiJDaGFsbGVuZ2VCb3NzQXZhdGFyUmVsaWNJbmZvLnByb3RvGhxDaGFsbGVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Z2VCb3NzUmVsaWNJbmZvLnByb3RvIsgBChxDaGFsbGVuZ2VCb3NzQXZhdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "UmVsaWNJbmZvElQKFWF2YXRhcl9yZWxpY19zbG90X21hcBgBIAMoCzI1LkNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "YWxsZW5nZUJvc3NBdmF0YXJSZWxpY0luZm8uQXZhdGFyUmVsaWNTbG90TWFw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "RW50cnkaUgoXQXZhdGFyUmVsaWNTbG90TWFwRW50cnkSCwoDa2V5GAEgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "EiYKBXZhbHVlGAIgASgLMhcuQ2hhbGxlbmdlQm9zc1JlbGljSW5mbzoCOAFC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[1] { ChallengeBossRelicInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossAvatarRelicInfo), ChallengeBossAvatarRelicInfo.Parser, new string[1] { "AvatarRelicSlotMap" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
