using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GCFNNAKLMPDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GCFNNAKLMPDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQ0ZOTkFLTE1QRC5wcm90byINCgtHQ0ZOTkFLTE1QREIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GCFNNAKLMPD), GCFNNAKLMPD.Parser, null, null, null, null, null)
		}));
	}
}
