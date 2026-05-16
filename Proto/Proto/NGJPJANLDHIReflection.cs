using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NGJPJANLDHIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NGJPJANLDHIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOR0pQSkFOTERISS5wcm90byIiCgtOR0pQSkFOTERISRITCgtGSERQRU1D" + "QUJJRRgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NGJPJANLDHI), NGJPJANLDHI.Parser, new string[1] { "FHDPEMCABIE" }, null, null, null, null)
		}));
	}
}
