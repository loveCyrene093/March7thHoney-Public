using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RotateMapCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RotateMapCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChRSb3RhdGVNYXBDc1JlcS5wcm90bxoQTW90aW9uSW5mby5wcm90bxoTUm90";
		buffer[1] = "YXRlTWFwSW5mby5wcm90byJ5Cg5Sb3RhdGVNYXBDc1JlcRIbCgZtb3Rpb24Y";
		buffer[2] = "AiABKAsyCy5Nb3Rpb25JbmZvEhAKCGdyb3VwX2lkGAQgASgNEiMKC0FNTUpF";
		buffer[3] = "Q0hQR1BFGAYgASgLMg4uUm90YXRlTWFwSW5mbxITCgtQQk9MTUJMS0RORBgO";
		buffer[4] = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MotionInfoReflection.Descriptor,
			RotateMapInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RotateMapCsReq), RotateMapCsReq.Parser, new string[4] { "Motion", "GroupId", "AMMJECHPGPE", "PBOLMBLKDND" }, null, null, null, null)
		}));
	}
}
