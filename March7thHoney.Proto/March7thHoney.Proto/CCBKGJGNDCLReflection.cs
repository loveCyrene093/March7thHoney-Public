using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CCBKGJGNDCLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CCBKGJGNDCLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQ0JLR0pHTkRDTC5wcm90bxoRTkhQS01NRE9ISUgucHJvdG8iUwoLQ0NC" + "S0dKR05EQ0wSIQoLRkdLQU9NSUpKQk4YAyADKAsyDC5OSFBLTU1ET0hJSBIR" + "Cgljb3N0X3RpbWUYCCABKA0SDgoGbWFwX2lkGAwgASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { NHPKMMDOHIHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CCBKGJGNDCL), CCBKGJGNDCL.Parser, new string[3] { "FGKAOMIJJBN", "CostTime", "MapId" }, null, null, null, null)
		}));
	}
}
