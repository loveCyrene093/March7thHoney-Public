using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GFNGJAJAJJHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GFNGJAJAJJHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHRk5HSkFKQUpKSC5wcm90bxoRQkFGUE5DUEhORkYucHJvdG8aEUtIQ0hQ";
		buffer[1] = "UExPRkpOLnByb3RvInYKC0dGTkdKQUpBSkpIEiEKC0RETEZMUEtOTFBMGAEg";
		buffer[2] = "ASgLMgwuQkFGUE5DUEhORkYSIQoLQ05KUExQTkNNTFAYBCABKAsyDC5LSENI";
		buffer[3] = "UFBMT0ZKThIhCgtOQU9ESU5ERUtMTRgKIAMoCzIMLktIQ0hQUExPRkpOQhaq";
		buffer[4] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BAFPNCPHNFFReflection.Descriptor,
			KHCHPPLOFJNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GFNGJAJAJJH), GFNGJAJAJJH.Parser, new string[3] { "DDLFLPKNLPL", "CNJPLPNCMLP", "NAODINDEKLM" }, null, null, null, null)
		}));
	}
}
