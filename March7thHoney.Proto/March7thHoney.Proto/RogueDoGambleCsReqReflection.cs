using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueDoGambleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueDoGambleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSb2d1ZURvR2FtYmxlQ3NSZXEucHJvdG8iLAoSUm9ndWVEb0dhbWJsZUNz" + "UmVxEhYKDnByb3BfZW50aXR5X2lkGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueDoGambleCsReq), RogueDoGambleCsReq.Parser, new string[1] { "PropEntityId" }, null, null, null, null)
		}));
	}
}
