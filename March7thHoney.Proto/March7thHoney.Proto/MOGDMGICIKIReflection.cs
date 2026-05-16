using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MOGDMGICIKIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MOGDMGICIKIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNT0dETUdJQ0lLSS5wcm90bxoRTUpMTFBBQU9QTVAucHJvdG8iRQoLTU9H" + "RE1HSUNJS0kSEwoLQ0hEUE5DT0hBR0gYASABKA0SIQoLSEhPSE5DTkZBRUQY" + "AiADKAsyDC5NSkxMUEFBT1BNUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { MJLLPAAOPMPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MOGDMGICIKI), MOGDMGICIKI.Parser, new string[2] { "CHDPNCOHAGH", "HHOHNCNFAED" }, null, null, null, null)
		}));
	}
}
