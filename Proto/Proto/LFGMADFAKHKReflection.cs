using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LFGMADFAKHKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LFGMADFAKHKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMRkdNQURGQUtISy5wcm90byqBAQoLTEZHTUFERkFLSEsSGwoXTEZHTUFE";
		buffer[1] = "RkFLSEtfUENQREhFTFBLRU0QABIbChdMRkdNQURGQUtIS19OTUJDRElMREdO";
		buffer[2] = "SxABEhsKF0xGR01BREZBS0hLX0tMSERDT1BQTE5HEAISGwoXTEZHTUFERkFL";
		buffer[3] = "SEtfQ0xQSE1BSkpJTEEQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LFGMADFAKHK) }, null, null));
	}
}
