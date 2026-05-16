using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGMBMAAPCCNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGMBMAAPCCNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBR01CTUFBUENDTi5wcm90byIiCgtBR01CTUFBUENDThITCgtDSEZHSEFM" + "TUtOQRgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AGMBMAAPCCN), AGMBMAAPCCN.Parser, new string[1] { "CHFGHALMKNA" }, null, null, null, null)
		}));
	}
}
