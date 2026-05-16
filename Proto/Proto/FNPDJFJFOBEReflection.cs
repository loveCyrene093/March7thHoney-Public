using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FNPDJFJFOBEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FNPDJFJFOBEReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFGTlBESkZKRk9CRS5wcm90byq7AQoLRk5QREpGSkZPQkUSGwoXRk5QREpG";
		buffer[1] = "SkZPQkVfRUtFRkNMSkFQRFAQABIbChdGTlBESkZKRk9CRV9OSFBOTktJRUdH";
		buffer[2] = "TBABEhsKF0ZOUERKRkpGT0JFX0JQRU1OTUtBUE9PEAISGwoXRk5QREpGSkZP";
		buffer[3] = "QkVfSk1LSkRGRUZJT0IQAxIbChdGTlBESkZKRk9CRV9OR0VMTE1CSE9JRRAE";
		buffer[4] = "EhsKF0ZOUERKRkpGT0JFX05BTlBEQUtCSk1PEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FNPDJFJFOBE) }, null, null));
	}
}
