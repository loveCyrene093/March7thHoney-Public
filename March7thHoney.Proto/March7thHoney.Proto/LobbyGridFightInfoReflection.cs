using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyGridFightInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyGridFightInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhMb2JieUdyaWRGaWdodEluZm8ucHJvdG8iXgoSTG9iYnlHcmlkRmlnaHRJ" + "bmZvEhMKC0lIR0JCSEVCTEtMGAEgAygNEgwKBGdvbGQYAiABKA0SEAoIc2Nv" + "cmVfaWQYAyABKA0SEwoLRkNGR0JBRENHQ0MYBCABKAlCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyGridFightInfo), LobbyGridFightInfo.Parser, new string[4] { "IHGBBHEBLKL", "Gold", "ScoreId", "FCFGBADCGCC" }, null, null, null, null)
		}));
	}
}
