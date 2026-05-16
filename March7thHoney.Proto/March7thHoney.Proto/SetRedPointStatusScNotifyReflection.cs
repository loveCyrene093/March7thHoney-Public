using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetRedPointStatusScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetRedPointStatusScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch9TZXRSZWRQb2ludFN0YXR1c1NjTm90aWZ5LnByb3RvGhFGQUpHTE9GSUNF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SS5wcm90byKJAQoZU2V0UmVkUG9pbnRTdGF0dXNTY05vdGlmeRIhCgtBUE1D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "S09ERUdCSxgBIAMoCzIMLkZBSkdMT0ZJQ0VJEhMKC0pNSUVOQkJNUEFHGAMg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ASgNEhMKC05GREFKSEpER09KGAggASgNEhIKCmNvbnRlbnRfaWQYCyABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "CwoDdWlkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { FAJGLOFICEIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetRedPointStatusScNotify), SetRedPointStatusScNotify.Parser, new string[5] { "APMCKODEGBK", "JMIENBBMPAG", "NFDAJHJDGOJ", "ContentId", "Uid" }, null, null, null, null)
		}));
	}
}
