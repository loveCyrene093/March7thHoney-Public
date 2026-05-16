using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GrowthTargetStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GrowthTargetStateReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChdHcm93dGhUYXJnZXRTdGF0ZS5wcm90byrBAQoRR3Jvd3RoVGFyZ2V0U3Rh";
		buffer[1] = "dGUSGwoXSERKS0dNTEFGTlBfQUFCSkZJS0JISksQABIbChdIREpLR01MQUZO";
		buffer[2] = "UF9ORE5LREZIRUhCQxABEhsKF0hESktHTUxBRk5QX0lQQkZBQUNJR0hOEAIS";
		buffer[3] = "GwoXSERKS0dNTEFGTlBfT09OSktDREdDS04QAxIbChdIREpLR01MQUZOUF9J";
		buffer[4] = "RUFKRUZBTEZMRxAEEhsKF0hESktHTUxBRk5QX05FR0dKT0dITUFLEAVCFqoC";
		buffer[5] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GrowthTargetState) }, null, null));
	}
}
