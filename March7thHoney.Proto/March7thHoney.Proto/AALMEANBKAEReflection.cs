using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AALMEANBKAEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AALMEANBKAEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQUxNRUFOQktBRS5wcm90byIeCgtBQUxNRUFOQktBRRIPCgdhcmVhX2lk" + "GAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AALMEANBKAE), AALMEANBKAE.Parser, new string[1] { "AreaId" }, null, null, null, null)
		}));
	}
}
