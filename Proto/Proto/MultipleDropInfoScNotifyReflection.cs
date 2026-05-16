using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MultipleDropInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MultipleDropInfoScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5NdWx0aXBsZURyb3BJbmZvU2NOb3RpZnkucHJvdG8aEURNSU5MTEROTkRM" + "LnByb3RvIj0KGE11bHRpcGxlRHJvcEluZm9TY05vdGlmeRIhCgtERkVPT0VI" + "RkFBQxgGIAMoCzIMLkRNSU5MTEROTkRMQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { DMINLLDNNDLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MultipleDropInfoScNotify), MultipleDropInfoScNotify.Parser, new string[1] { "DFEOOEHFAAC" }, null, null, null, null)
		}));
	}
}
