using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BPJDOEMBNMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BPJDOEMBNMDReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFCUEpET0VNQk5NRC5wcm90bxoRQkNGQUpBTVBES0YucHJvdG8aEURMQ0ZO";
		buffer[1] = "RU9KR0JCLnByb3RvGhNGaWdodEdhbWVNb2RlLnByb3RvGhFORUpKRExPQ0dD";
		buffer[2] = "TC5wcm90byLCAQoLQlBKRE9FTUJOTUQSIwoLUExPQk1CRlBORksYBSABKA4y";
		buffer[3] = "Di5GaWdodEdhbWVNb2RlEhAKCHBhbmVsX2lkGA4gASgNEiMKC0pBS0ZBREFE";
		buffer[4] = "Tk9OGAggASgLMgwuRExDRk5FT0pHQkJIABIjCgtGSEVDRkhESEZKQxgJIAEo";
		buffer[5] = "CzIMLkJDRkFKQU1QREtGSAASIwoLSkJCQUNMTENGT04YCiABKAsyDC5ORUpK";
		buffer[6] = "RExPQ0dDTEgAQg0KC0ZMQkNNQUNQSE1KQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[7] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BCFAJAMPDKFReflection.Descriptor,
			DLCFNEOJGBBReflection.Descriptor,
			FightGameModeReflection.Descriptor,
			NEJJDLOCGCLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BPJDOEMBNMD), BPJDOEMBNMD.Parser, new string[5] { "PLOBMBFPNFK", "PanelId", "JAKFADADNON", "FHECFHDHFJC", "JBBACLLCFON" }, new string[1] { "FLBCMACPHMJ" }, null, null, null)
		}));
	}
}
