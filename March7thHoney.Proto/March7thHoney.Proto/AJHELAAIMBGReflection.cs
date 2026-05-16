using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AJHELAAIMBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AJHELAAIMBGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSkhFTEFBSU1CRy5wcm90byIiCgtBSkhFTEFBSU1CRxITCgtISU5HTUVC" + "SUJETBgKIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AJHELAAIMBG), AJHELAAIMBG.Parser, new string[1] { "HINGMEBIBDL" }, null, null, null, null)
		}));
	}
}
