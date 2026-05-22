using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChargerInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChargerInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDaGFyZ2VySW5mby5wcm90byI0CgtDaGFyZ2VySW5mbxITCgtQQk9MTUJM" + "S0RORBgFIAEoDRIQCghncm91cF9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChargerInfo), ChargerInfo.Parser, new string[2] { "PBOLMBLKDND", "GroupId" }, null, null, null, null)
		}));
	}
}
