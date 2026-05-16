using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JCCMGOOPHBOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JCCMGOOPHBOReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFKQ0NNR09PUEhCTy5wcm90bxoOSXRlbUxpc3QucHJvdG8inwEKC0pDQ01H";
		buffer[1] = "T09QSEJPEhMKC0hER0hDT0pJQ0VHGAEgASgNEg4KBm1hcF9pZBgGIAEoDRIT";
		buffer[2] = "CgtNTFBHR0lQQ05HRhgKIAEoDRITCgtKTEVMQkNGT0JLThgLIAEoDRITCgtE";
		buffer[3] = "RUtOR05ITEZOSRgMIAEoDRIRCgltYXhfc2NvcmUYDSABKA0SGQoGcmV3YXJk";
		buffer[4] = "GA4gASgLMgkuSXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[5] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCCMGOOPHBO), JCCMGOOPHBO.Parser, new string[7] { "HDGHCOJICEG", "MapId", "MLPGGIPCNGF", "JLELBCFOBKN", "DEKNGNHLFNI", "MaxScore", "Reward" }, null, null, null, null)
		}));
	}
}
