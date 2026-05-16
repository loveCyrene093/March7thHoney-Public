using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JNMOPCFJDPDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JNMOPCFJDPDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTk1PUENGSkRQRC5wcm90byJNCgtKTk1PUENGSkRQRBIPCgdpdGVtX2lk" + "GAIgASgNEhMKC0NMQUZORExHREFPGAMgASgNEhgKEGl0ZW1fc3RhY2tfY291" + "bnQYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JNMOPCFJDPD), JNMOPCFJDPD.Parser, new string[3] { "ItemId", "CLAFNDLGDAO", "ItemStackCount" }, null, null, null, null)
		}));
	}
}
