using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyRollDiceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyRollDiceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNb25vcG9seVJvbGxEaWNlQ3NSZXEucHJvdG8iFwoVTW9ub3BvbHlSb2xs" + "RGljZUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyRollDiceCsReq), MonopolyRollDiceCsReq.Parser, null, null, null, null, null)
		}));
	}
}
