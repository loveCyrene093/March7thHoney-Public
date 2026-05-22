using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FDDNDPOPOIAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FDDNDPOPOIAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRERORFBPUE9JQS5wcm90byIeCgtGRERORFBPUE9JQRIPCgdyb2xlX2lk" + "GA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FDDNDPOPOIA), FDDNDPOPOIA.Parser, new string[1] { "RoleId" }, null, null, null, null)
		}));
	}
}
