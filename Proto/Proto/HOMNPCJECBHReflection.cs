using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HOMNPCJECBHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HOMNPCJECBHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIT01OUENKRUNCSC5wcm90bxoRRE9HR0lETklOSlAucHJvdG8iMAoLSE9N" + "TlBDSkVDQkgSIQoLRU5QR0FHQk1IT0UYBCABKAsyDC5ET0dHSUROSU5KUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DOGGIDNINJPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HOMNPCJECBH), HOMNPCJECBH.Parser, new string[1] { "ENPGAGBMHOE" }, null, null, null, null)
		}));
	}
}
