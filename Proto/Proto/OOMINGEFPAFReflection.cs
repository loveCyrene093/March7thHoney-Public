using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OOMINGEFPAFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OOMINGEFPAFReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFPT01JTkdFRlBBRi5wcm90bxoRQUxNQ0lFUE9PRFAucHJvdG8i7gEKC09P";
		buffer[1] = "TUlOR0VGUEFGEhQKDGNoYWxsZW5nZV9pZBgBIAEoDRITCgtQQUFKRExCQklL";
		buffer[2] = "RxgCIAEoDRITCgtJR0lFSEVPQ01KTBgEIAMoDRITCgtCS05QUEFFT0xKSBgF";
		buffer[3] = "IAEoDRIhCgtJRE9JRERFSElKRxgGIAMoCzIMLkFMTUNJRVBPT0RQEhMKC05H";
		buffer[4] = "QkFDSUNBQVBPGAcgASgNEhMKC0pKT0dHQklPSUtCGAwgASgNEhMKC1BJTFBB";
		buffer[5] = "R0pFRU5CGA0gASgIEhMKC0JLTUVER0ZPTUtGGA4gASgNEhMKC2F2YXRhcl9s";
		buffer[6] = "aXN0GA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ALMCIEPOODPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OOMINGEFPAF), OOMINGEFPAF.Parser, new string[10] { "ChallengeId", "PAAJDLBBIKG", "IGIEHEOCMJL", "BKNPPAEOLJH", "IDOIDDEHIJG", "NGBACICAAPO", "JJOGGBIOIKB", "PILPAGJEENB", "BKMEDGFOMKF", "AvatarList" }, null, null, null, null)
		}));
	}
}
