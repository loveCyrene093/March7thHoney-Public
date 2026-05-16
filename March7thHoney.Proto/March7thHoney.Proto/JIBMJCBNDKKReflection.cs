using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JIBMJCBNDKKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JIBMJCBNDKKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFKSUJNSkNCTkRLSy5wcm90bxoRQ0dPRU5FTktLQ0cucHJvdG8aEUdCSEhP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TUhOTEtELnByb3RvImgKC0pJQk1KQ0JOREtLEiEKC01JTEhNSUNFRUdQGAQg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgLMgwuQ0dPRU5FTktLQ0cSEwoLSE9IQU5QSk5BTkEYCSABKA0SIQoLR0VJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SkRPQktOQUQYCyADKAsyDC5HQkhIT01ITkxLREIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			CGOENENKKCGReflection.Descriptor,
			GBHHOMHNLKDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JIBMJCBNDKK), JIBMJCBNDKK.Parser, new string[3] { "MILHMICEEGP", "HOHANPJNANA", "GEIJDOBKNAD" }, null, null, null, null)
		}));
	}
}
