using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ABIPCNKGFNIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ABIPCNKGFNIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQklQQ05LR0ZOSS5wcm90bxoRUFBQRk9NQkxPSUYucHJvdG8iagoLQUJJ" + "UENOS0dGTkkSIQoLRkxITEpNRU1JSEwYASADKAsyDC5QUFBGT01CTE9JRhIQ" + "CghlbmRfdGltZRgEIAEoAxIRCglnaWZ0X3R5cGUYCCABKA0SEwoLRE5OSENO" + "Q0tKQ00YCyABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { PPPFOMBLOIFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ABIPCNKGFNI), ABIPCNKGFNI.Parser, new string[4] { "FLHLJMEMIHL", "EndTime", "GiftType", "DNNHCNCKJCM" }, null, null, null, null)
		}));
	}
}
