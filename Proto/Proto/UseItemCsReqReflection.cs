using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UseItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UseItemCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChJVc2VJdGVtQ3NSZXEucHJvdG8aEEF2YXRhclR5cGUucHJvdG8iqgEKDFVz";
		buffer[1] = "ZUl0ZW1Dc1JlcRIaChJvcHRpb25hbF9yZXdhcmRfaWQYBCABKA0SJAoPdXNl";
		buffer[2] = "X2F2YXRhcl90eXBlGAUgASgOMgsuQXZhdGFyVHlwZRITCgtNSE9DUEZERUdO";
		buffer[3] = "RhgGIAEoCBIWCg51c2VfaXRlbV9jb3VudBgHIAEoDRIWCg5iYXNlX2F2YXRh";
		buffer[4] = "cl9pZBgJIAEoDRITCgt1c2VfaXRlbV9pZBgOIAEoDUIWqgITTWFyY2g3dGhI";
		buffer[5] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UseItemCsReq), UseItemCsReq.Parser, new string[6] { "OptionalRewardId", "UseAvatarType", "MHOCPFDEGNF", "UseItemCount", "BaseAvatarId", "UseItemId" }, null, null, null, null)
		}));
	}
}
