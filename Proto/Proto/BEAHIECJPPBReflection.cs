using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BEAHIECJPPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BEAHIECJPPBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCRUFISUVDSlBQQi5wcm90byIiCgtCRUFISUVDSlBQQhITCgtDTENQTFBQ" + "Tk5FSBgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BEAHIECJPPB), BEAHIECJPPB.Parser, new string[1] { "CLCPLPPNNEH" }, null, null, null, null)
		}));
	}
}
