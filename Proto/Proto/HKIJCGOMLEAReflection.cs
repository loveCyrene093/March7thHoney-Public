using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HKIJCGOMLEAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HKIJCGOMLEAReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChFIS0lKQ0dPTUxFQS5wcm90bxoRQURITkpBRElKQUMucHJvdG8aEUZJS05M";
		buffer[1] = "RkJJUEhLLnByb3RvGhNGaWdodEdhbWVNb2RlLnByb3RvGhFOSkJOSEhBUEtI";
		buffer[2] = "Qi5wcm90bxoRUEJJQ0pDUERMR0QucHJvdG8aEVBGTkFPR0pERU1OLnByb3Rv";
		buffer[3] = "IpACCgtIS0lKQ0dPTUxFQRIKCgJpZBgBIAEoBBIjCgtJQlBMSE5BQUVJQhgC";
		buffer[4] = "IAEoDjIOLkZpZ2h0R2FtZU1vZGUSIQoLTE1OS0NKRUhFTU4YAyADKAsyDC5B";
		buffer[5] = "REhOSkFESUpBQxIaCgR0eXBlGAQgASgOMgwuUEZOQU9HSkRFTU4SEwoLTUdE";
		buffer[6] = "Tk9BQ0JGT0UYBSABKAQSEwoLQkdISUNJQk9MTEkYBiABKAQSIQoLT0ZDS0NO";
		buffer[7] = "RE9CT00YCCABKA4yDC5OSkJOSEhBUEtIQhIhCgtQT0ZPQ01JSEpJQRgJIAEo";
		buffer[8] = "CzIMLlBCSUNKQ1BETEdEEiEKC01HRk1MQkRFSE5MGAsgASgLMgwuRklLTkxG";
		buffer[9] = "QklQSEtCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[6]
		{
			ADHNJADIJACReflection.Descriptor,
			FIKNLFBIPHKReflection.Descriptor,
			FightGameModeReflection.Descriptor,
			NJBNHHAPKHBReflection.Descriptor,
			PBICJCPDLGDReflection.Descriptor,
			PFNAOGJDEMNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HKIJCGOMLEA), HKIJCGOMLEA.Parser, new string[9] { "Id", "IBPLHNAAEIB", "LMNKCJEHEMN", "Type", "MGDNOACBFOE", "BGHICIBOLLI", "OFCKCNDOBOM", "POFOCMIHJIA", "MGFMLBDEHNL" }, null, null, null, null)
		}));
	}
}
