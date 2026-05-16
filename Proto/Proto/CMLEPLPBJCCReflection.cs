using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMLEPLPBJCCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMLEPLPBJCCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTUxFUExQQkpDQy5wcm90bxoRQUJISUxHRkxKTk8ucHJvdG8iQgoLQ01M" + "RVBMUEJKQ0MSIQoLRkdPQ0RDTUtETUwYBiADKAsyDC5BQkhJTEdGTEpOTxIQ" + "CghmbG9vcl9pZBgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[1] { ABHILGFLJNOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMLEPLPBJCC), CMLEPLPBJCC.Parser, new string[2] { "FGOCDCMKDML", "FloorId" }, null, null, null, null)
		}));
	}
}
