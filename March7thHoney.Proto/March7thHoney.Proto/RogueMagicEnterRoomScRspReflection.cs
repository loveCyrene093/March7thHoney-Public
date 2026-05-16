using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicEnterRoomScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicEnterRoomScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZU1hZ2ljRW50ZXJSb29tU2NSc3AucHJvdG8aEUpLQUlES0lHRUdQ" + "LnByb3RvIk4KGFJvZ3VlTWFnaWNFbnRlclJvb21TY1JzcBIPCgdyZXRjb2Rl" + "GAIgASgNEiEKC0FGTEpKSkZDQklOGAogASgLMgwuSktBSURLSUdFR1BCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { JKAIDKIGEGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicEnterRoomScRsp), RogueMagicEnterRoomScRsp.Parser, new string[2] { "Retcode", "AFLJJJFCBIN" }, null, null, null, null)
		}));
	}
}
