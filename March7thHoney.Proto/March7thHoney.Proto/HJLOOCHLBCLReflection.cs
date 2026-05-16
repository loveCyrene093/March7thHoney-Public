using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HJLOOCHLBCLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HJLOOCHLBCLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISkxPT0NITEJDTC5wcm90byJNCgtISkxPT0NITEJDTBIPCgdpdGVtX2lk" + "GAYgASgNEhgKEGl0ZW1fc3RhY2tfY291bnQYCCABKA0SEwoLQ0xBRk5ETEdE" + "QU8YCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HJLOOCHLBCL), HJLOOCHLBCL.Parser, new string[3] { "ItemId", "ItemStackCount", "CLAFNDLGDAO" }, null, null, null, null)
		}));
	}
}
