using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EMBCNJNGMKIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EMBCNJNGMKIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTUJDTkpOR01LSS5wcm90byI3CgtFTUJDTkpOR01LSRITCgtQQU5GSVBI" + "QUdQQhgBIAEoDRITCgtLQkFESkRGTEFQRRgCIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EMBCNJNGMKI), EMBCNJNGMKI.Parser, new string[2] { "PANFIPHAGPB", "KBADJDFLAPE" }, null, null, null, null)
		}));
	}
}
