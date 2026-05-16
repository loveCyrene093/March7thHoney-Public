using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NPLALEFPIEEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NPLALEFPIEEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOUExBTEVGUElFRS5wcm90byJJCgtOUExBTEVGUElFRRIQCghldmVudF9p" + "ZBgBIAEoDRITCgtBTUFERkpOSE1GRhgOIAEoDRITCgtGQ0FESkVFTkdNTBgP" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NPLALEFPIEE), NPLALEFPIEE.Parser, new string[3] { "EventId", "AMADFJNHMFF", "FCADJEENGML" }, null, null, null, null)
		}));
	}
}
