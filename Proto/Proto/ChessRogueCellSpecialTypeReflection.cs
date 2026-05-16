using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueCellSpecialTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueCellSpecialTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch9DaGVzc1JvZ3VlQ2VsbFNwZWNpYWxUeXBlLnByb3RvKskBChlDaGVzc1Jv";
		buffer[1] = "Z3VlQ2VsbFNwZWNpYWxUeXBlEhsKF1BLRkVHQ0hHQ0VFX1BDUERIRUxQS0VN";
		buffer[2] = "EAASGwoXUEtGRUdDSEdDRUVfQkdJQlBEUE5GQkMQARIbChdQS0ZFR0NIR0NF";
		buffer[3] = "RV9DRkdBTEFKT05DUBACEhsKF1BLRkVHQ0hHQ0VFX0hBR0NMS0NLR0pEEAMS";
		buffer[4] = "GwoXUEtGRUdDSEdDRUVfS0JIR0FKQ05OQk0QBBIbChdQS0ZFR0NIR0NFRV9Q";
		buffer[5] = "QU1NRENQR0FNRRAFQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChessRogueCellSpecialType) }, null, null));
	}
}
