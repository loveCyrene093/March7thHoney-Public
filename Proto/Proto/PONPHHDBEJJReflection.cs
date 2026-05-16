using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PONPHHDBEJJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PONPHHDBEJJReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFQT05QSEhEQkVKSi5wcm90byqSAgoLUE9OUEhIREJFSkoSGwoXUE9OUEhI";
		buffer[1] = "REJFSkpfT0VHTENMTkpLRUMQABIbChdQT05QSEhEQkVKSl9GUEFMRktNTkJI";
		buffer[2] = "ShABEhsKF1BPTlBISERCRUpKX01KSUlCRk9KSUhLEAISGwoXUE9OUEhIREJF";
		buffer[3] = "SkpfQ09BTUJLQkpPRlAQAxIbChdQT05QSEhEQkVKSl9MSkxKQ0dLQ0RMSBAE";
		buffer[4] = "EhsKF1BPTlBISERCRUpKX09FT0FMQUFCTEZGEAUSGwoXUE9OUEhIREJFSkpf";
		buffer[5] = "SEpPQkNMQU9HQ0kQBhIbChdQT05QSEhEQkVKSl9HQVBCREVOQktGSBAHEhsK";
		buffer[6] = "F1BPTlBISERCRUpKX0JOTExOQ0tOQUNJEAhCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[7] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PONPHHDBEJJ) }, null, null));
	}
}
