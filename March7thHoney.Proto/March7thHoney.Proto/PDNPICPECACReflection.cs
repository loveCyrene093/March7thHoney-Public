using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PDNPICPECACReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PDNPICPECACReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQRE5QSUNQRUNBQy5wcm90byIeCgtQRE5QSUNQRUNBQxIPCgdyZXRjb2Rl" + "GA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PDNPICPECAC), PDNPICPECAC.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
