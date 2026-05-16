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
		buffer[0] = "Ch9DaGVzc1JvZ3VlQm9hcmRDZWxsU3RhdHVzLnByb3RvKo8BChlDaGVzc1Jv";
		buffer[1] = "Z3VlQm9hcmRDZWxsU3RhdHVzEhsKF0dCSUtDSlBHTEJLX0dIR0FQT0FLR0FC";
		buffer[2] = "EAASGwoXR0JJS0NKUEdMQktfSEdOR0FETklMRkMQARIbChdHQklLQ0pQR0xC";
		buffer[3] = "S19IUEpFQkZGSEpOUBACEhsKF0dCSUtDSlBHTEJLX0tMSERDT1BQTE5HEANC";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChessRogueBoardCellStatus) }, null, null));
	}
}
