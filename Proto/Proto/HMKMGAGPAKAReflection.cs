using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HMKMGAGPAKAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HMKMGAGPAKAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITUtNR0FHUEFLQS5wcm90byIyCgtITUtNR0FHUEFLQRIPCgdpdGVtX2lk" + "GAUgASgNEhIKCml0ZW1fY291bnQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HMKMGAGPAKA), HMKMGAGPAKA.Parser, new string[2] { "ItemId", "ItemCount" }, null, null, null, null)
		}));
	}
}
