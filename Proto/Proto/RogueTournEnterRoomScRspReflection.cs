using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnterRoomScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnterRoomScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZVRvdXJuRW50ZXJSb29tU2NSc3AucHJvdG8aEUJGRUlQRUxGQ0RG" + "LnByb3RvIk4KGFJvZ3VlVG91cm5FbnRlclJvb21TY1JzcBIPCgdyZXRjb2Rl" + "GAIgASgNEiEKC0FGTEpKSkZDQklOGA4gASgLMgwuQkZFSVBFTEZDREZCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { BFEIPELFCDFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterRoomScRsp), RogueTournEnterRoomScRsp.Parser, new string[2] { "Retcode", "AFLJJJFCBIN" }, null, null, null, null)
		}));
	}
}
