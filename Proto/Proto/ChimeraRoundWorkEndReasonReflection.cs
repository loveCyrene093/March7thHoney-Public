using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraRoundWorkEndReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraRoundWorkEndReasonReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9DaGltZXJhUm91bmRXb3JrRW5kUmVhc29uLnByb3RvKo8BChlDaGltZXJh";
		buffer[1] = "Um91bmRXb3JrRW5kUmVhc29uEhsKF0RKRkZJQ0VFQkFBX09EQ0VPTUpBQ01F";
		buffer[2] = "EAASGwoXREpGRklDRUVCQUFfT0hGR0ZCTEJIRUsQARIbChdESkZGSUNFRUJB";
		buffer[3] = "QV9DR0xGR0ZIQkVLQhACEhsKF0RKRkZJQ0VFQkFBX0dHREtETENQQUpBEANC";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChimeraRoundWorkEndReason) }, null, null));
	}
}
