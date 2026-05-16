using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReserveStaminaExchangeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReserveStaminaExchangeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNlcnZlU3RhbWluYUV4Y2hhbmdlQ3NSZXEucHJvdG8iKgobUmVzZXJ2" + "ZVN0YW1pbmFFeGNoYW5nZUNzUmVxEgsKA251bRgMIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReserveStaminaExchangeCsReq), ReserveStaminaExchangeCsReq.Parser, new string[1] { "Num" }, null, null, null, null)
		}));
	}
}
