using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExchangeRogueRewardKeyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExchangeRogueRewardKeyScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFFeGNoYW5nZVJvZ3VlUmV3YXJkS2V5U2NSc3AucHJvdG8iPQobRXhjaGFu" + "Z2VSb2d1ZVJld2FyZEtleVNjUnNwEg0KBWNvdW50GAQgASgNEg8KB3JldGNv" + "ZGUYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeRogueRewardKeyScRsp), ExchangeRogueRewardKeyScRsp.Parser, new string[2] { "Count", "Retcode" }, null, null, null, null)
		}));
	}
}
