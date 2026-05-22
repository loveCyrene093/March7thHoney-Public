using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeadIconDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeadIconDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJIZWFkSWNvbkRhdGEucHJvdG8iGgoMSGVhZEljb25EYXRhEgoKAmlkGAQg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeadIconData), HeadIconData.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
