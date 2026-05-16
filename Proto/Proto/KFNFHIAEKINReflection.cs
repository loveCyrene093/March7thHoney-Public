using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KFNFHIAEKINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KFNFHIAEKINReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFLRk5GSElBRUtJTi5wcm90bxoRRVBMSUdKRUdFTUoucHJvdG8ikwEKC0tG";
		buffer[1] = "TkZISUFFS0lOEhMKC0ZQT0lFRkhPSElOGAIgASgNEiEKC05FQlBBTklESU1H";
		buffer[2] = "GAMgAygLMgwuRVBMSUdKRUdFTUoSIQoLRUZHR0RERUFMR00YBSADKAsyDC5F";
		buffer[3] = "UExJR0pFR0VNShIUCgx0b3RhbF9kYW1hZ2UYByABKAESEwoLQUtBQkRER05M";
		buffer[4] = "Q1AYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EPLIGJEGEMJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KFNFHIAEKIN), KFNFHIAEKIN.Parser, new string[5] { "FPOIEFHOHIN", "NEBPANIDIMG", "EFGGDDEALGM", "TotalDamage", "AKABDDGNLCP" }, null, null, null, null)
		}));
	}
}
