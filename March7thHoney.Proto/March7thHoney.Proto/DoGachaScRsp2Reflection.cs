using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DoGachaScRsp2Reflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DoGachaScRsp2Reflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChNEb0dhY2hhU2NSc3AyLnByb3RvGhFHTUtDRkNHTUpLSS5wcm90bxoRT0pD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "S0xDS0hQTE0ucHJvdG8iewoNRG9HYWNoYVNjUnNwMhIhCgtKS0FNSElLSUJF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ShgBIAMoCzIMLkdNS0NGQ0dNSktJEiEKC1BLTklMRUtLSVBMGAwgAygLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "T0pDS0xDS0hQTE0SEwoLQkVETE1ESE5NQkoYDiABKA0SDwoHcmV0Y29kZRgP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GMKCFCGMJKIReflection.Descriptor,
			OJCKLCKHPLMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaScRsp2), DoGachaScRsp2.Parser, new string[4] { "JKAMHIKIBEJ", "PKNILEKKIPL", "BEDLMDHNMBJ", "Retcode" }, null, null, null, null)
		}));
	}
}
