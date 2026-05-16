using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MLGALLEAEICReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MLGALLEAEICReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFNTEdBTExFQUVJQy5wcm90bxoRR0RLUEJEQUFLQkgucHJvdG8aEUtCTklK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RkVNQlBKLnByb3RvIn0KC01MR0FMTEVBRUlDEhMKC0lITUtKR0tPUEtDGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgIEhMKC0lKSU1GUEVLUE9LGAcgASgNEiEKC09BR01BRUxNREFFGAggASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "MgwuS0JOSUpGRU1CUEoSIQoLRkhLRU1DTEZCT04YCSABKAsyDC5HREtQQkRB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QUtCSEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GDKPBDAAKBHReflection.Descriptor,
			KBNIJFEMBPJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MLGALLEAEIC), MLGALLEAEIC.Parser, new string[4] { "IHMKJGKOPKC", "IJIMFPEKPOK", "OAGMAELMDAE", "FHKEMCLFBON" }, null, null, null, null)
		}));
	}
}
