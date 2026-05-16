using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CDAAOJFMALOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CDAAOJFMALOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDREFBT0pGTUFMTy5wcm90byIiCgtDREFBT0pGTUFMTxITCgtEQVBPRkxI" + "TU1QShgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CDAAOJFMALO), CDAAOJFMALO.Parser, new string[1] { "DAPOFLHMMPJ" }, null, null, null, null)
		}));
	}
}
