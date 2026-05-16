using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMLBJFHEAKLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMLBJFHEAKLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTUxCSkZIRUFLTC5wcm90byJJCgtNTUxCSkZIRUFLTBIQCghwYW5lbF9p" + "ZBgBIAEoDRITCgtNS0hESU5ER0hNRBgCIAEoDRITCgtFTk5MSktKR01FSRgD" + "IAEoBEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MMLBJFHEAKL), MMLBJFHEAKL.Parser, new string[3] { "PanelId", "MKHDINDGHMD", "ENNLJKJGMEI" }, null, null, null, null)
		}));
	}
}
