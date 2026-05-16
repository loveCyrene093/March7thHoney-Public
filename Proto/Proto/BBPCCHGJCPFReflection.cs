using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBPCCHGJCPFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBPCCHGJCPFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFCQlBDQ0hHSkNQRi5wcm90bxoRRUlCT0JLRUpBS00ucHJvdG8irgEKC0JC";
		buffer[1] = "UENDSEdKQ1BGEhMKC0JOR09EQk5KQkNPGAEgASgNEhMKC05OSUZKUExCREtD";
		buffer[2] = "GAIgASgNEhMKC0lGS0tHTUZMRkpLGAMgASgNEhMKC0lKREtPSUFBSUxHGAQg";
		buffer[3] = "AygNEiEKC0FESUlDR0VCSk9HGAUgAygLMgwuRUlCT0JLRUpBS00SEwoLUE9K";
		buffer[4] = "RkxMT09QTEYYBiABKA0SEwoLTkpFTE1FT09JR04YByABKA1CFqoCE01hcmNo";
		buffer[5] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EIBOBKEJAKMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBPCCHGJCPF), BBPCCHGJCPF.Parser, new string[7] { "BNGODBNJBCO", "NNIFJPLBDKC", "IFKKGMFLFJK", "IJDKOIAAILG", "ADIICGEBJOG", "POJFLLOOPLF", "NJELMEOOIGN" }, null, null, null, null)
		}));
	}
}
