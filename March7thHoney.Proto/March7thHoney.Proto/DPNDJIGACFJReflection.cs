using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPNDJIGACFJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPNDJIGACFJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEUE5ESklHQUNGSi5wcm90bxoRS0FJRUxKUE1HSEwucHJvdG8iRQoLRFBO" + "REpJR0FDRkoSEwoLUEhDQUFMQlBLR0sYBiADKA0SIQoLQ01HQ05GTEdITE0Y" + "CyABKAsyDC5LQUlFTEpQTUdITEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { KAIELJPMGHLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPNDJIGACFJ), DPNDJIGACFJ.Parser, new string[2] { "PHCAALBPKGK", "CMGCNFLGHLM" }, null, null, null, null)
		}));
	}
}
