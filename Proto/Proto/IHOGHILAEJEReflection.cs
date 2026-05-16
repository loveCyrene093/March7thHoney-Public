using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IHOGHILAEJEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IHOGHILAEJEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSE9HSElMQUVKRS5wcm90byI3CgtJSE9HSElMQUVKRRITCgtOTVBHTktJ" + "TlBMTBgHIAEoDRITCgtJR0hOQUVESkJBRxgLIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IHOGHILAEJE), IHOGHILAEJE.Parser, new string[2] { "NMPGNKINPLL", "IGHNAEDJBAG" }, null, null, null, null)
		}));
	}
}
