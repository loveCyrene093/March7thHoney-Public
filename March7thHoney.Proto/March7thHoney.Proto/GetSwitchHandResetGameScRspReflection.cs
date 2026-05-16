using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSwitchHandResetGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSwitchHandResetGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRTd2l0Y2hIYW5kUmVzZXRHYW1lU2NSc3AucHJvdG8aEUdPREhERUlQ" + "REpMLnByb3RvIlEKG0dldFN3aXRjaEhhbmRSZXNldEdhbWVTY1JzcBIhCgtM" + "Rk5JUEVDS05ESBgEIAEoCzIMLkdPREhERUlQREpMEg8KB3JldGNvZGUYCSAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { GODHDEIPDJLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSwitchHandResetGameScRsp), GetSwitchHandResetGameScRsp.Parser, new string[2] { "LFNIPECKNDH", "Retcode" }, null, null, null, null)
		}));
	}
}
