using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ContentPackageTransferScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ContentPackageTransferScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRDb250ZW50UGFja2FnZVRyYW5zZmVyU2NOb3RpZnkucHJvdG8iIAoeQ29u" + "dGVudFBhY2thZ2VUcmFuc2ZlclNjTm90aWZ5QhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageTransferScNotify), ContentPackageTransferScNotify.Parser, null, null, null, null, null)
		}));
	}
}
