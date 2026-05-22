using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectPamSkinScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectPamSkinScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZWxlY3RQYW1Ta2luU2NSc3AucHJvdG8iSQoSU2VsZWN0UGFtU2tpblNj" + "UnNwEhAKCGN1cl9za2luGAQgASgNEg8KB3JldGNvZGUYDiABKA0SEAoIc2V0" + "X3NraW4YDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectPamSkinScRsp), SelectPamSkinScRsp.Parser, new string[3] { "CurSkin", "Retcode", "SetSkin" }, null, null, null, null)
		}));
	}
}
