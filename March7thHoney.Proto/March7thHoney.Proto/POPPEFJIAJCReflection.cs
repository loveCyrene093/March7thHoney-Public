using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class POPPEFJIAJCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static POPPEFJIAJCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQT1BQRUZKSUFKQy5wcm90byIyCgtQT1BQRUZKSUFKQxIOCgZpc193aW4Y" + "ByABKAgSEwoLRUZERE5NR0xBTkYYCCABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(POPPEFJIAJC), POPPEFJIAJC.Parser, new string[2] { "IsWin", "EFDDNMGLANF" }, null, null, null, null)
		}));
	}
}
