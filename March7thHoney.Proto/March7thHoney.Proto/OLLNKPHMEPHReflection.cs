using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OLLNKPHMEPHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OLLNKPHMEPHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTExOS1BITUVQSC5wcm90byI3CgtPTExOS1BITUVQSBIXCg9tYWluX21p" + "c3Npb25faWQYAiABKA0SDwoHcmV0Y29kZRgJIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OLLNKPHMEPH), OLLNKPHMEPH.Parser, new string[2] { "MainMissionId", "Retcode" }, null, null, null, null)
		}));
	}
}
