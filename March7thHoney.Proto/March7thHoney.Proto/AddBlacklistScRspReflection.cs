using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AddBlacklistScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AddBlacklistScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdBZGRCbGFja2xpc3RTY1JzcC5wcm90bxoWUGxheWVyU2ltcGxlSW5mby5w" + "cm90byJLChFBZGRCbGFja2xpc3RTY1JzcBIlCgpibGFja19pbmZvGAggASgL" + "MhEuUGxheWVyU2ltcGxlSW5mbxIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PlayerSimpleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AddBlacklistScRsp), AddBlacklistScRsp.Parser, new string[2] { "BlackInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
