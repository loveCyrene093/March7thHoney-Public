using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IMJMGHCHFAAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IMJMGHCHFAAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTUpNR0hDSEZBQS5wcm90byIzCgtJTUpNR0hDSEZBQRIPCgdyZXRjb2Rl" + "GAogASgNEhMKC0lOQ0hMSE5LSENIGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IMJMGHCHFAA), IMJMGHCHFAA.Parser, new string[2] { "Retcode", "INCHLHNKHCH" }, null, null, null, null)
		}));
	}
}
