using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MKPOHKOPAPEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MKPOHKOPAPEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNS1BPSEtPUEFQRS5wcm90byIiCgtNS1BPSEtPUEFQRRITCgtGQlBDSUJI" + "RU9IRRgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MKPOHKOPAPE), MKPOHKOPAPE.Parser, new string[1] { "FBPCIBHEOHE" }, null, null, null, null)
		}));
	}
}
