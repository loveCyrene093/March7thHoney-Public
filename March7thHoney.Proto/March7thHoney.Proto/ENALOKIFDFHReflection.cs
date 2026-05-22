using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ENALOKIFDFHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ENALOKIFDFHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTkFMT0tJRkRGSC5wcm90byJeCgtFTkFMT0tJRkRGSBIQCghwYW5lbF9p" + "ZBgDIAEoDRITCgtGQURGQ01NTkRESxgFIAEoDRITCgtLTE9CRUVPSkJDThgK" + "IAEoDRITCgtGSEpCTUJMRkFGSBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ENALOKIFDFH), ENALOKIFDFH.Parser, new string[4] { "PanelId", "FADFCMMNDDK", "KLOBEEOJBCN", "FHJBMBLFAFH" }, null, null, null, null)
		}));
	}
}
