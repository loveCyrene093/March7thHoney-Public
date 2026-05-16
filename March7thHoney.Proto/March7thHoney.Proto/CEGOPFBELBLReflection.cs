using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CEGOPFBELBLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CEGOPFBELBLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDRUdPUEZCRUxCTC5wcm90byJMCgtDRUdPUEZCRUxCTBITCgtLS0ZCTEpO" + "TURGShgHIAEoDRITCgtQR0tMT01BSk1EQxgLIAMoDRITCgtLQkZET1BOT0RC" + "TBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CEGOPFBELBL), CEGOPFBELBL.Parser, new string[3] { "KKFBLJNMDFJ", "PGKLOMAJMDC", "KBFDOPNODBL" }, null, null, null, null)
		}));
	}
}
