using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CIPBBPHGEKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CIPBBPHGEKJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSVBCQlBIR0VLSi5wcm90byJLCgtDSVBCQlBIR0VLShIUCgxwYXNzZW5n" + "ZXJfaWQYAiABKA0SEQoJdW5pcXVlX2lkGAkgASgNEhMKC0tLSU9JRkxKRUVM" + "GA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CIPBBPHGEKJ), CIPBBPHGEKJ.Parser, new string[3] { "PassengerId", "UniqueId", "KKIOIFLJEEL" }, null, null, null, null)
		}));
	}
}
