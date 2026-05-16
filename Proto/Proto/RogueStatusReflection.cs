using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueStatusReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFSb2d1ZVN0YXR1cy5wcm90byqeAQoLUm9ndWVTdGF0dXMSGwoXSkJGTUhH";
		buffer[1] = "S05FR0xfUENQREhFTFBLRU0QABIbChdKQkZNSEdLTkVHTF9OTUJDRElMREdO";
		buffer[2] = "SxABEhsKF0pCRk1IR0tORUdMX09QTkFERktCR05OEAISGwoXSkJGTUhHS05F";
		buffer[3] = "R0xfT0VLRkxHRUZHUFAQAxIbChdKQkZNSEdLTkVHTF9LTEhEQ09QUExORxAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RogueStatus) }, null, null));
	}
}
