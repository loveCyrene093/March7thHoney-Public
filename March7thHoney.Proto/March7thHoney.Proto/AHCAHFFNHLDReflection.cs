using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AHCAHFFNHLDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AHCAHFFNHLDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSENBSEZGTkhMRC5wcm90bxoQUmVwbGF5SW5mby5wcm90byJACgtBSENB" + "SEZGTkhMRBIPCgdyZXRjb2RlGAwgASgNEiAKC0xMRklCT0hQQUhCGA0gAygL" + "MgsuUmVwbGF5SW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ReplayInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AHCAHFFNHLD), AHCAHFFNHLD.Parser, new string[2] { "Retcode", "LLFIBOHPAHB" }, null, null, null, null)
		}));
	}
}
