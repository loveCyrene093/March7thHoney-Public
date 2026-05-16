using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueSelectCellScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueSelectCellScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9DaGVzc1JvZ3VlU2VsZWN0Q2VsbFNjUnNwLnByb3RvGhFCSkhERE1DRkFN";
		buffer[1] = "Ri5wcm90byJ5ChlDaGVzc1JvZ3VlU2VsZWN0Q2VsbFNjUnNwEhMKC0pOTE5N";
		buffer[2] = "SE9PRUtMGAUgASgNEhMKC0VJSUFHQUJBRkVDGAYgASgNEiEKC0tBRUFMTEVM";
		buffer[3] = "QUROGAggASgLMgwuQkpIRERNQ0ZBTUYSDwoHcmV0Y29kZRgJIAEoDUIWqgIT";
		buffer[4] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BJHDDMCFAMFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueSelectCellScRsp), ChessRogueSelectCellScRsp.Parser, new string[4] { "JNLNMHOOEKL", "EIIAGABAFEC", "KAEALLELADN", "Retcode" }, null, null, null, null)
		}));
	}
}
