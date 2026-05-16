using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OECPLDABABLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OECPLDABABLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRUNQTERBQkFCTC5wcm90byJhCgtPRUNQTERBQkFCTBITCgtETVBHTkxJ" + "Qk5ERRgFIAEoDRITCgtFSEpCTU5NT0ZMRhgHIAEoDRITCgtGR0ZCSkxBRExK" + "QhgIIAEoBRITCgtJR0ZJSExCTkROTRgJIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OECPLDABABL), OECPLDABABL.Parser, new string[4] { "DMPGNLIBNDE", "EHJBMNMOFLF", "FGFBJLADLJB", "IGFIHLBNDNM" }, null, null, null, null)
		}));
	}
}
