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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch9DaGVzc1JvZ3VlQ2VsbFNwZWNpYWxUeXBlLnByb3RvKskBChlDaGVzc1Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Z3VlQ2VsbFNwZWNpYWxUeXBlEhsKF1BLRkVHQ0hHQ0VFX1BDUERIRUxQS0VN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "EAASGwoXUEtGRUdDSEdDRUVfQkdJQlBEUE5GQkMQARIbChdQS0ZFR0NIR0NF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "RV9DRkdBTEFKT05DUBACEhsKF1BLRkVHQ0hHQ0VFX0hBR0NMS0NLR0pEEAMS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "GwoXUEtGRUdDSEdDRUVfS0JIR0FKQ05OQk0QBBIbChdQS0ZFR0NIR0NFRV9Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "QU1NRENQR0FNRRAFQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChessRogueCellSpecialType) }, null, null));
	}
}
