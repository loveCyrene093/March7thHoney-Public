using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueLayerSettlementReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueLayerSettlementReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9DaGVzc1JvZ3VlTGF5ZXJTZXR0bGVtZW50LnByb3RvGhFGSUlMUEhLTEZF";
		buffer[1] = "Sy5wcm90byJtChlDaGVzc1JvZ3VlTGF5ZXJTZXR0bGVtZW50EhgKEGRpZmZp";
		buffer[2] = "Y3VsdHlfbGV2ZWwYBCABKA0SIQoLTkRNTEVHTElPR04YDCABKAsyDC5GSUlM";
		buffer[3] = "UEhLTEZFSxITCgtJTkdDRElBRkFGRxgPIAEoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FIILPHKLFEKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueLayerSettlement), ChessRogueLayerSettlement.Parser, new string[3] { "DifficultyLevel", "NDMLEGLIOGN", "INGCDIAFAFG" }, null, null, null, null)
		}));
	}
}
