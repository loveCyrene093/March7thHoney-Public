using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OPBCCOLPDPCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OPBCCOLPDPCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPUEJDQ09MUERQQy5wcm90byIiCgtPUEJDQ09MUERQQxITCgtQTU9HSEZJ" + "R0tQTxgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OPBCCOLPDPC), OPBCCOLPDPC.Parser, new string[1] { "PMOGHFIGKPO" }, null, null, null, null)
		}));
	}
}
