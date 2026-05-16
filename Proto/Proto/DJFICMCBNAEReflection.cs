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
		buffer[0] = "ChFESkZJQ01DQk5BRS5wcm90bxoRRENPS0tCSEtFR0wucHJvdG8ihQEKC0RK";
		buffer[1] = "RklDTUNCTkFFEiEKC1BBTUdITURKQUpBGAsgASgLMgwuRENPS0tCSEtFR0wS";
		buffer[2] = "JQoddW5maW5pc2hlZF9zdG9yeV9saW5lX2lkX2xpc3QYDCADKA0SDwoHcmV0";
		buffer[3] = "Y29kZRgNIAEoDRIbChNiYXNlX2F2YXRhcl9pZF9saXN0GA8gAygNQhaqAhNN";
		buffer[4] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { DCOKKBHKEGLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DJFICMCBNAE), DJFICMCBNAE.Parser, new string[4] { "PAMGHMDJAJA", "UnfinishedStoryLineIdList", "Retcode", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
