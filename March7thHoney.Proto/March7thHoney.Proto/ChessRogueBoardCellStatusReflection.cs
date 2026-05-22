using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueBoardCellStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueBoardCellStatusReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch9DaGVzc1JvZ3VlQm9hcmRDZWxsU3RhdHVzLnByb3RvKo8BChlDaGVzc1Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Z3VlQm9hcmRDZWxsU3RhdHVzEhsKF0dCSUtDSlBHTEJLX0dIR0FQT0FLR0FC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EAASGwoXR0JJS0NKUEdMQktfSEdOR0FETklMRkMQARIbChdHQklLQ0pQR0xC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "S19IUEpFQkZGSEpOUBACEhsKF0dCSUtDSlBHTEJLX0tMSERDT1BQTE5HEANC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChessRogueBoardCellStatus) }, null, null));
	}
}
