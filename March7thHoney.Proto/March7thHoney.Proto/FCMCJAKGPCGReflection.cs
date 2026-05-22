using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCMCJAKGPCGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCMCJAKGPCGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ01DSkFLR1BDRy5wcm90byI3CgtGQ01DSkFLR1BDRxITCgtQUEVCRkFK" + "SkVORxgBIAEoDRITCgtMSkhOTkJGQk1KShgCIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCMCJAKGPCG), FCMCJAKGPCG.Parser, new string[2] { "PPEBFAJJENG", "LJHNNBFBMJJ" }, null, null, null, null)
		}));
	}
}
