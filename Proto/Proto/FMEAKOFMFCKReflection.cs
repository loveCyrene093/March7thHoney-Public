using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FMEAKOFMFCKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FMEAKOFMFCKReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFGTUVBS09GTUZDSy5wcm90byqaAgoLRk1FQUtPRk1GQ0sSGwoXRk1FQUtP";
		buffer[1] = "Rk1GQ0tfUENQREhFTFBLRU0QABIcChdGTUVBS09GTUZDS19DR0NKTEhGTEVQ";
		buffer[2] = "ThCTAxIcChdGTUVBS09GTUZDS19MQ0RESkZBRktQTBCUAxIcChdGTUVBS09G";
		buffer[3] = "TUZDS19QSklHSE5GSEZLRBCRAxIcChdGTUVBS09GTUZDS19QR0RGR01QT0lG";
		buffer[4] = "RBCSAxIcChdGTUVBS09GTUZDS19BSkJGQ09ESk9ORhD8ERIcChdGTUVBS09G";
		buffer[5] = "TUZDS19FUE5DUEJDREFLTxCcGBIcChdGTUVBS09GTUZDS19HSE9ESVBDT0lJ";
		buffer[6] = "RRCEIBIcChdGTUVBS09GTUZDS19PQkJFQ0RFS0pGRRD0HEIWqgITTWFyY2g3";
		buffer[7] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FMEAKOFMFCK) }, null, null));
	}
}
