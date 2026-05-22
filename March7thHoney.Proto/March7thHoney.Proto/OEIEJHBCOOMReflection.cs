using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEIEJHBCOOMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEIEJHBCOOMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRUlFSkhCQ09PTS5wcm90byJhCgtPRUlFSkhCQ09PTRITCgtNQk9FRkxB" + "SExFTRgDIAEoDRITCgtQQVBPS0FDSVBQShgJIAEoDRITCgtER09NSERNSkhF" + "SxgMIAMoDRITCgtJUExMTU5QQU5JRBgPIAMoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OEIEJHBCOOM), OEIEJHBCOOM.Parser, new string[4] { "MBOEFLAHLEM", "PAPOKACIPPJ", "DGOMHDMJHEK", "IPLLMNPANID" }, null, null, null, null)
		}));
	}
}
