using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BJOBDLDHOCCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BJOBDLDHOCCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSk9CRExESE9DQy5wcm90byI3CgtCSk9CRExESE9DQxITCgtQQU5GSVBI" + "QUdQQhgBIAEoDRITCgtJQU1DUEtNTkFOTxgCIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BJOBDLDHOCC), BJOBDLDHOCC.Parser, new string[2] { "PANFIPHAGPB", "IAMCPKMNANO" }, null, null, null, null)
		}));
	}
}
