using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGetRafflePoolInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGetRafflePoolInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRNb25vcG9seUdldFJhZmZsZVBvb2xJbmZvQ3NSZXEucHJvdG8iIAoeTW9u" + "b3BvbHlHZXRSYWZmbGVQb29sSW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGetRafflePoolInfoCsReq), MonopolyGetRafflePoolInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
