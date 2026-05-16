using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FAGCFBEBKEOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FAGCFBEBKEOReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFGQUdDRkJFQktFTy5wcm90bxoRTE9IS0ZLT09FSUgucHJvdG8iwQEKC0ZB";
		buffer[1] = "R0NGQkVCS0VPEhMKC1BMS0pDQU1CQUlDGAEgASgNEhMKC0JLS0VGRkdHRUZB";
		buffer[2] = "GAIgASgNEhMKC01CSkNDS0xOSUJNGAMgASgNEhMKC0JMREVQRUxBSUhNGAQg";
		buffer[3] = "ASgNEhMKC0hFSE1DQU5ES0pLGAUgASgNEhMKC0RHUFBFQVBMTVBBGAYgASgN";
		buffer[4] = "EhEKCWJvc3NfaW5mbxgHIAMoDRIhCgtLSkZMQ0JETkxDRhgIIAMoCzIMLkxP";
		buffer[5] = "SEtGS09PRUlIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { LOHKFKOOEIHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FAGCFBEBKEO), FAGCFBEBKEO.Parser, new string[8] { "PLKJCAMBAIC", "BKKEFFGGEFA", "MBJCCKLNIBM", "BLDEPELAIHM", "HEHMCANDKJK", "DGPPEAPLMPA", "BossInfo", "KJFLCBDNLCF" }, null, null, null, null)
		}));
	}
}
