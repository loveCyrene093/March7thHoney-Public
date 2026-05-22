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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch9DaGVzc1JvZ3VlTGF5ZXJTZXR0bGVtZW50LnByb3RvGhFGSUlMUEhLTEZF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Sy5wcm90byJtChlDaGVzc1JvZ3VlTGF5ZXJTZXR0bGVtZW50EhgKEGRpZmZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Y3VsdHlfbGV2ZWwYBCABKA0SIQoLTkRNTEVHTElPR04YDCABKAsyDC5GSUlM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "UEhLTEZFSxITCgtJTkdDRElBRkFGRxgPIAEoDUIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { FIILPHKLFEKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueLayerSettlement), ChessRogueLayerSettlement.Parser, new string[3] { "DifficultyLevel", "NDMLEGLIOGN", "INGCDIAFAFG" }, null, null, null, null)
		}));
	}
}
