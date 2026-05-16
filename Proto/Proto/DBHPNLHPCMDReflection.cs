using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DBHPNLHPCMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DBHPNLHPCMDReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFEQkhQTkxIUENNRC5wcm90bxoRSktMRkJERkpMSkgucHJvdG8imQEKC0RC";
		buffer[1] = "SFBOTEhQQ01EEiEKC0hOQ0RNSElESUpMGAEgAygLMgwuSktMRkJERkpMSkgS";
		buffer[2] = "EwoLSUxDSERHS09EUEUYAiABKA0SEwoLTFBBR0tIR0NDRkgYBSABKA0SEwoL";
		buffer[3] = "QVBISlBKQklNRkIYByABKA0SEwoLRktFR0FJSE5PREUYCCABKA0SEwoLTkZH";
		buffer[4] = "RlBNRUtQSE4YCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[5] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JKLFBDFJLJHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DBHPNLHPCMD), DBHPNLHPCMD.Parser, new string[6] { "HNCDMHIDIJL", "ILCHDGKODPE", "LPAGKHGCCFH", "APHJPJBIMFB", "FKEGAIHNODE", "NFGFPMEKPHN" }, null, null, null, null)
		}));
	}
}
