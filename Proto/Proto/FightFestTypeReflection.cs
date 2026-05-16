using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightFestTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightFestTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChNGaWdodEZlc3RUeXBlLnByb3RvKqABCg1GaWdodEZlc3RUeXBlEhsKF01I";
		buffer[1] = "S0VBRkFQTUZQX1BDUERIRUxQS0VNEAASGwoXTUhLRUFGQVBNRlBfUEVPQUNO";
		buffer[2] = "UEtNRFAQARIbChdNSEtFQUZBUE1GUF9GQU1NTElOR0xEQRACEhsKF01IS0VB";
		buffer[3] = "RkFQTUZQX09QQ0dOSk1HSkRFEAMSGwoXTUhLRUFGQVBNRlBfRU5ETktLT0lC";
		buffer[4] = "SEUQBEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FightFestType) }, null, null));
	}
}
