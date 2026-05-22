using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PEEDNOBMBNNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PEEDNOBMBNNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQRUVETk9CTUJOTi5wcm90bxoRQURNQ01GSUlOSUgucHJvdG8aEUhBQ05C" + "SkpPTEhQLnByb3RvIlMKC1BFRUROT0JNQk5OEiEKC0dIRUtJRUFPTUxKGAMg" + "ASgLMgwuQURNQ01GSUlOSUgSIQoLTUhDQUJDRUROR0IYCiADKAsyDC5IQUNO" + "QkpKT0xIUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			ADMCMFIINIHReflection.Descriptor,
			HACNBJJOLHPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PEEDNOBMBNN), PEEDNOBMBNN.Parser, new string[2] { "GHEKIEAOMLJ", "MHCABCEDNGB" }, null, null, null, null)
		}));
	}
}
