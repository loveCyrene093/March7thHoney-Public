using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LBJMGIHILGBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LBJMGIHILGBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMQkpNR0lISUxHQi5wcm90bxoRRUZFR0tESEVNRk4ucHJvdG8ifQoLTEJK";
		buffer[1] = "TUdJSElMR0ISIQoLRUZHRUxKSkZMS0wYAiABKAsyDC5FRkVHS0RIRU1GThIT";
		buffer[2] = "CgtBTkhHTkxITk9LRRgGIAEoAxIhCgtJR0xDRURCQ0tGSBgIIAEoCzIMLkVG";
		buffer[3] = "RUdLREhFTUZOEhMKC0JIREhJSUJDRElKGAsgASgNQhaqAhNNYXJjaDd0aEhv";
		buffer[4] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EFEGKDHEMFNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LBJMGIHILGB), LBJMGIHILGB.Parser, new string[4] { "EFGELJJFLKL", "ANHGNLHNOKE", "IGLCEDBCKFH", "BHDHIIBCDIJ" }, null, null, null, null)
		}));
	}
}
