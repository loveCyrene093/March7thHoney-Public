using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHEDJAIOHOEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHEDJAIOHOEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSEVESkFJT0hPRS5wcm90byI3CgtMSEVESkFJT0hPRRITCgtOSkRCSUVN" + "QU9BQRgIIAEoDRITCgtNQU9OTEhCS09GSxgKIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHEDJAIOHOE), LHEDJAIOHOE.Parser, new string[2] { "NJDBIEMAOAA", "MAONLHBKOFK" }, null, null, null, null)
		}));
	}
}
