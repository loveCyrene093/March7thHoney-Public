using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DOJACNBCEEHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DOJACNBCEEHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFET0pBQ05CQ0VFSC5wcm90byIiCgtET0pBQ05CQ0VFSBITCgtISElNSU5C" + "R0pESRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DOJACNBCEEH), DOJACNBCEEH.Parser, new string[1] { "HHIMINBGJDI" }, null, null, null, null)
		}));
	}
}
