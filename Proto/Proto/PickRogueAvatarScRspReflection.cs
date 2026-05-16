using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PickRogueAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PickRogueAvatarScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpQaWNrUm9ndWVBdmF0YXJTY1JzcC5wcm90bxoRTVBLR0xHQ0xBSUQucHJv";
		buffer[1] = "dG8iZwoUUGlja1JvZ3VlQXZhdGFyU2NSc3ASIQoLTEJOSEtQUEFKSU0YBiAB";
		buffer[2] = "KAsyDC5NUEtHTEdDTEFJRBIbChNiYXNlX2F2YXRhcl9pZF9saXN0GAkgAygN";
		buffer[3] = "Eg8KB3JldGNvZGUYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MPKGLGCLAIDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PickRogueAvatarScRsp), PickRogueAvatarScRsp.Parser, new string[3] { "LBNHKPPAJIM", "BaseAvatarIdList", "Retcode" }, null, null, null, null)
		}));
	}
}
