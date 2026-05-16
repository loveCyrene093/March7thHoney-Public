using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuyBpLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuyBpLevelScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCdXlCcExldmVsU2NSc3AucHJvdG8iIgoPQnV5QnBMZXZlbFNjUnNwEg8K" + "B3JldGNvZGUYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuyBpLevelScRsp), BuyBpLevelScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
