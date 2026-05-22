using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LNLMPKALPEFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LNLMPKALPEFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFMTkxNUEtBTFBFRi5wcm90bxoRQU5CT0ZLSEhETkUucHJvdG8aEUdES1BC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "REFBS0JILnByb3RvIn0KC0xOTE1QS0FMUEVGEiEKC0ZIS0VNQ0xGQk9OGAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgLMgwuR0RLUEJEQUFLQkgSEwoLQkhGRExDUEVQSE0YAiABKA0SEwoLQU9M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SE1FRkRBSEUYCSABKA0SIQoLSkJPQ09QTkVKTEIYDSADKAsyDC5BTkJPRktI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SERORUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ANBOFKHHDNEReflection.Descriptor,
			GDKPBDAAKBHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LNLMPKALPEF), LNLMPKALPEF.Parser, new string[4] { "FHKEMCLFBON", "BHFDLCPEPHM", "AOLHMEFDAHE", "JBOCOPNEJLB" }, null, null, null, null)
		}));
	}
}
