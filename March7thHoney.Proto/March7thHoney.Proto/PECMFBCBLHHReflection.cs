using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PECMFBCBLHHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PECMFBCBLHHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQRUNNRkJDQkxISC5wcm90byI0CgtQRUNNRkJDQkxISBITCgtITENPTUdI" + "TUxFUBgCIAMoDRIQCghzdGFnZV9pZBgNIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PECMFBCBLHH), PECMFBCBLHH.Parser, new string[2] { "HLCOMGHMLEP", "StageId" }, null, null, null, null)
		}));
	}
}
