using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLJLGPIFMJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLJLGPIFMJDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITEpMR1BJRk1KRC5wcm90byI0CgtITEpMR1BJRk1KRBITCgtBTUFERkpO" + "SE1GRhgMIAEoDRIQCghldmVudF9pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLJLGPIFMJD), HLJLGPIFMJD.Parser, new string[2] { "AMADFJNHMFF", "EventId" }, null, null, null, null)
		}));
	}
}
