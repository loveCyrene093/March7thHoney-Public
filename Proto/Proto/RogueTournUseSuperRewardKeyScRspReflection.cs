using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournUseSuperRewardKeyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournUseSuperRewardKeyScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiZSb2d1ZVRvdXJuVXNlU3VwZXJSZXdhcmRLZXlTY1JzcC5wcm90bxoOSXRl";
		buffer[1] = "bUxpc3QucHJvdG8aEU5OT0lKSk5DSEpCLnByb3RvIo8BCiBSb2d1ZVRvdXJu";
		buffer[2] = "VXNlU3VwZXJSZXdhcmRLZXlTY1JzcBIhCgtISUNORkpER0dHTBgBIAEoCzIM";
		buffer[3] = "Lk5OT0lKSk5DSEpCEg8KB3JldGNvZGUYDSABKA0SHAoJZHJvcF9kYXRhGA4g";
		buffer[4] = "ASgLMgkuSXRlbUxpc3QSGQoGcmV3YXJkGA8gASgLMgkuSXRlbUxpc3RCFqoC";
		buffer[5] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			NNOIJJNCHJBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournUseSuperRewardKeyScRsp), RogueTournUseSuperRewardKeyScRsp.Parser, new string[4] { "HICNFJDGGGL", "Retcode", "DropData", "Reward" }, null, null, null, null)
		}));
	}
}
