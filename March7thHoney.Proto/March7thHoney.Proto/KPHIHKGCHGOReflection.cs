using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KPHIHKGCHGOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KPHIHKGCHGOReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFLUEhJSEtHQ0hHTy5wcm90bxoRREFKS05ISUxDRUEucHJvdG8aEUpNTElK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TEVLQkVBLnByb3RvImYKC0tQSElIS0dDSEdPEiMKC0xKQkxGTURGSEpFGA0g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgLMgwuSk1MSUpMRUtCRUFIABIjCgtGTk1CSUlHQ0xCShgOIAEoCzIMLkRB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SktOSElMQ0VBSABCDQoLQlBJSEZBSkNMT0NCFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			DAJKNHILCEAReflection.Descriptor,
			JMLIJLEKBEAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KPHIHKGCHGO), KPHIHKGCHGO.Parser, new string[2] { "LJBLFMDFHJE", "FNMBIIGCLBJ" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
