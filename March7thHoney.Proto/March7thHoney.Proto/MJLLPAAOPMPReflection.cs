using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MJLLPAAOPMPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MJLLPAAOPMPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSkxMUEFBT1BNUC5wcm90byIyCgtNSkxMUEFBT1BNUBIPCgdpdGVtX2lk" + "GAEgASgNEhIKCml0ZW1fY291bnQYAiABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJLLPAAOPMP), MJLLPAAOPMP.Parser, new string[2] { "ItemId", "ItemCount" }, null, null, null, null)
		}));
	}
}
