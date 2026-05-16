using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DJFICMCBNAEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DJFICMCBNAEReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFESkZJQ01DQk5BRS5wcm90bxoRRENPS0tCSEtFR0wucHJvdG8ihQEKC0RK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RklDTUNCTkFFEiEKC1BBTUdITURKQUpBGAsgASgLMgwuRENPS0tCSEtFR0wS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "JQoddW5maW5pc2hlZF9zdG9yeV9saW5lX2lkX2xpc3QYDCADKA0SDwoHcmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Y29kZRgNIAEoDRIbChNiYXNlX2F2YXRhcl9pZF9saXN0GA8gAygNQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { DCOKKBHKEGLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DJFICMCBNAE), DJFICMCBNAE.Parser, new string[4] { "PAMGHMDJAJA", "UnfinishedStoryLineIdList", "Retcode", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
