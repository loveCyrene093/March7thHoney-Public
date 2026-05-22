using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuickStartFarmElementScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuickStartFarmElementScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBRdWlja1N0YXJ0RmFybUVsZW1lbnRTY1JzcC5wcm90bxoVU2NlbmVCYXR0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bGVJbmZvLnByb3RvIoABChpRdWlja1N0YXJ0RmFybUVsZW1lbnRTY1JzcBIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Cgt3b3JsZF9sZXZlbBgGIAEoDRIVCg1GYXJtRWxlbWVudElkGAcgASgNEiUK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "C2JhdHRsZV9pbmZvGAkgASgLMhAuU2NlbmVCYXR0bGVJbmZvEg8KB3JldGNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuickStartFarmElementScRsp), QuickStartFarmElementScRsp.Parser, new string[4] { "WorldLevel", "FarmElementId", "BattleInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
