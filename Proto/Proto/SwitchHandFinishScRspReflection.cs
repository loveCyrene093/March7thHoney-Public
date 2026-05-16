using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchHandFinishScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchHandFinishScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTd2l0Y2hIYW5kRmluaXNoU2NSc3AucHJvdG8aEUdPREhERUlQREpMLnBy" + "b3RvIksKFVN3aXRjaEhhbmRGaW5pc2hTY1JzcBIhCgtPTUhBRU5CSUtDThgJ" + "IAEoCzIMLkdPREhERUlQREpMEg8KB3JldGNvZGUYCiABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { GODHDEIPDJLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandFinishScRsp), SwitchHandFinishScRsp.Parser, new string[2] { "OMHAENBIKCN", "Retcode" }, null, null, null, null)
		}));
	}
}
