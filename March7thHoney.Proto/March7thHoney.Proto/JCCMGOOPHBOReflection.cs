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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFKQ0NNR09PUEhCTy5wcm90bxoOSXRlbUxpc3QucHJvdG8inwEKC0pDQ01H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "T09QSEJPEhMKC0hER0hDT0pJQ0VHGAEgASgNEg4KBm1hcF9pZBgGIAEoDRIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "CgtNTFBHR0lQQ05HRhgKIAEoDRITCgtKTEVMQkNGT0JLThgLIAEoDRITCgtE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "RUtOR05ITEZOSRgMIAEoDRIRCgltYXhfc2NvcmUYDSABKA0SGQoGcmV3YXJk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "GA4gASgLMgkuSXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCCMGOOPHBO), JCCMGOOPHBO.Parser, new string[7] { "HDGHCOJICEG", "MapId", "MLPGGIPCNGF", "JLELBCFOBKN", "DEKNGNHLFNI", "MaxScore", "Reward" }, null, null, null, null)
		}));
	}
}
