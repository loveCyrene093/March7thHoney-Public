using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HMNAPNOMPMEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HMNAPNOMPMEReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFITU5BUE5PTVBNRS5wcm90byKEAgoLSE1OQVBOT01QTUUSEwoLREJQT0VN";
		buffer[1] = "TkJNUEEYASABKA0SEwoLR0pGTUFGSU5NT0kYAiABKA0SEwoLQUVERkdISEJD";
		buffer[2] = "SkgYAyABKAgSEwoLRE9LTkZPTEtOS08YBCABKA0SEwoLSUZGREdESlBBTkoY";
		buffer[3] = "BSADKA0SEwoLRU9GQ0VDUE1ITEMYBiADKA0SEwoLSUhLREdDRkNFSE0YByAB";
		buffer[4] = "KA0SDgoGZGFtYWdlGAggASgNEhMKC0lKRUtIQkZJRURBGAkgASgNEhMKC0FN";
		buffer[5] = "R09FSUFMTUlBGAogASgIEhMKC05DTkhDQUZLSk9JGAsgASgNEhMKC0ZBT0NF";
		buffer[6] = "RERIQURKGAwgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HMNAPNOMPME), HMNAPNOMPME.Parser, new string[12]
			{
				"DBPOEMNBMPA", "GJFMAFINMOI", "AEDFGHHBCJH", "DOKNFOLKNKO", "IFFDGDJPANJ", "EOFCECPMHLC", "IHKDGCFCEHM", "Damage", "IJEKHBFIEDA", "AMGOEIALMIA",
				"NCNHCAFKJOI", "FAOCEDDHADJ"
			}, null, null, null, null)
		}));
	}
}
