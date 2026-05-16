using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PMNGJCDCGMMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PMNGJCDCGMMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQTU5HSkNEQ0dNTS5wcm90bxoRQkdDRUpEQ0hLQkEucHJvdG8aEURFTkJL";
		buffer[1] = "QU9IQkFNLnByb3RvIoEBCgtQTU5HSkNEQ0dNTRIaCgR0eXBlGAEgASgOMgwu";
		buffer[2] = "QkdDRUpEQ0hLQkESEQoJY29uZmlnX2lkGAIgASgNEhEKCXVuaXF1ZV9pZBgD";
		buffer[3] = "IAEoDRINCgVsZXZlbBgEIAEoDRIhCgtzd2l0Y2hfbGlzdBgFIAMoCzIMLkRF";
		buffer[4] = "TkJLQU9IQkFNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BGCEJDCHKBAReflection.Descriptor,
			DENBKAOHBAMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMNGJCDCGMM), PMNGJCDCGMM.Parser, new string[5] { "Type", "ConfigId", "UniqueId", "Level", "SwitchList" }, null, null, null, null)
		}));
	}
}
