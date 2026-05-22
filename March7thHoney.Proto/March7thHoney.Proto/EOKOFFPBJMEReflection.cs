using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EOKOFFPBJMEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EOKOFFPBJMEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFT0tPRkZQQkpNRS5wcm90byJMCgtFT0tPRkZQQkpNRRITCgtGR0ZCSkxB" + "RExKQhgDIAEoBRITCgtJR0ZJSExCTkROTRgGIAEoDRITCgtFSEpCTU5NT0ZM" + "RhgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EOKOFFPBJME), EOKOFFPBJME.Parser, new string[3] { "FGFBJLADLJB", "IGFIHLBNDNM", "EHJBMNMOFLF" }, null, null, null, null)
		}));
	}
}
