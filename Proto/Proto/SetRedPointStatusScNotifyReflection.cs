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
		buffer[0] = "Ch9TZXRSZWRQb2ludFN0YXR1c1NjTm90aWZ5LnByb3RvGhFGQUpHTE9GSUNF";
		buffer[1] = "SS5wcm90byKJAQoZU2V0UmVkUG9pbnRTdGF0dXNTY05vdGlmeRIhCgtBUE1D";
		buffer[2] = "S09ERUdCSxgBIAMoCzIMLkZBSkdMT0ZJQ0VJEhMKC0pNSUVOQkJNUEFHGAMg";
		buffer[3] = "ASgNEhMKC05GREFKSEpER09KGAggASgNEhIKCmNvbnRlbnRfaWQYCyABKA0S";
		buffer[4] = "CwoDdWlkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FAJGLOFICEIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetRedPointStatusScNotify), SetRedPointStatusScNotify.Parser, new string[5] { "APMCKODEGBK", "JMIENBBMPAG", "NFDAJHJDGOJ", "ContentId", "Uid" }, null, null, null, null)
		}));
	}
}
