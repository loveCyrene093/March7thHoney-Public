using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FMANPCKGFDDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FMANPCKGFDDReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFGTUFOUENLR0ZERC5wcm90byq7AQoLRk1BTlBDS0dGREQSGwoXRk1BTlBD";
		buffer[1] = "S0dGRERfTUFPRUpJRUFIQUgQABIbChdGTUFOUENLR0ZERF9LQ0NHTUhMQ0FF";
		buffer[2] = "TBABEhsKF0ZNQU5QQ0tHRkREX0lLSkdERkZPS0FEEAISGwoXRk1BTlBDS0dG";
		buffer[3] = "RERfR0pLTkNQSVBLQ00QAxIbChdGTUFOUENLR0ZERF9HRkxET0pMSU1ESBAE";
		buffer[4] = "EhsKF0ZNQU5QQ0tHRkREX0NPUEpFSUNKS05BEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FMANPCKGFDD) }, null, null));
	}
}
