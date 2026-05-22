using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSaveRaidScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSaveRaidScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChZHZXRTYXZlUmFpZFNjUnNwLnByb3RvGhRSYWlkVGFyZ2V0SW5mby5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "byKFAQoQR2V0U2F2ZVJhaWRTY1JzcBITCgt3b3JsZF9sZXZlbBgBIAEoDRIp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ChByYWlkX3RhcmdldF9pbmZvGAMgAygLMg8uUmFpZFRhcmdldEluZm8SDwoH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aXNfc2F2ZRgFIAEoCBIPCgdyZXRjb2RlGAcgASgNEg8KB3JhaWRfaWQYCSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { RaidTargetInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSaveRaidScRsp), GetSaveRaidScRsp.Parser, new string[5] { "WorldLevel", "RaidTargetInfo", "IsSave", "Retcode", "RaidId" }, null, null, null, null)
		}));
	}
}
