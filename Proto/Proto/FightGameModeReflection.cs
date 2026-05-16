using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightGameModeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightGameModeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChNGaWdodEdhbWVNb2RlLnByb3RvKpQCCg1GaWdodEdhbWVNb2RlEhsKF0VK";
		buffer[1] = "SU1JT0dBT0tMX1BDUERIRUxQS0VNEAASGwoXRUpJTUlPR0FPS0xfTkFOSERE";
		buffer[2] = "QkNKT0sQARIbChdFSklNSU9HQU9LTF9ET0RHQkhKRE5GTBACEhsKF0VKSU1J";
		buffer[3] = "T0dBT0tMX0ZMRkxLQkZHUE1QEAMSGwoXRUpJTUlPR0FPS0xfQk9JREZFSFBL";
		buffer[4] = "RUkQBBIbChdFSklNSU9HQU9LTF9JQ0xDR0pGQUVCTxAFEhsKF0VKSU1JT0dB";
		buffer[5] = "T0tMX0hHSkVMQURKTEpEEAYSGwoXRUpJTUlPR0FPS0xfSUtMS05FQkdGTEcQ";
		buffer[6] = "BxIbChdFSklNSU9HQU9LTF9IQVBJSkFNTUFLRhAIQhaqAhNNYXJjaDd0aEhv";
		buffer[7] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FightGameMode) }, null, null));
	}
}
