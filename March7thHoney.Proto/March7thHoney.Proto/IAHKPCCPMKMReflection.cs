using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IAHKPCCPMKMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IAHKPCCPMKMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQUhLUENDUE1LTS5wcm90byI0CgtJQUhLUENDUE1LTRITCgtKRU9QTk9O" + "Q0ZOUBgBIAEoDRIQCghzY29yZV9pZBgCIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IAHKPCCPMKM), IAHKPCCPMKM.Parser, new string[2] { "JEOPNONCFNP", "ScoreId" }, null, null, null, null)
		}));
	}
}
