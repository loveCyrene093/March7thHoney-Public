using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DAPPFJLEPLHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DAPPFJLEPLHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQVBQRkpMRVBMSC5wcm90byIyCgtEQVBQRkpMRVBMSBISCgppdGVtX2Nv" + "dW50GAEgASgNEg8KB2l0ZW1faWQYCyABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DAPPFJLEPLH), DAPPFJLEPLH.Parser, new string[2] { "ItemCount", "ItemId" }, null, null, null, null)
		}));
	}
}
