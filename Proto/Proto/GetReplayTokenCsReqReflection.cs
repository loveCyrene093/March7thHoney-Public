using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetReplayTokenCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetReplayTokenCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChlHZXRSZXBsYXlUb2tlbkNzUmVxLnByb3RvGhFPQ0xFSkxFRkJGTy5wcm90";
		buffer[1] = "byKeAQoTR2V0UmVwbGF5VG9rZW5Dc1JlcRITCgtFQk5GSEhHS0RLRRgBIAEo";
		buffer[2] = "CRIhCgtyZXBsYXlfdHlwZRgCIAEoDjIMLk9DTEVKTEVGQkZPEhMKC0tBTEFH";
		buffer[3] = "SUJDTkFPGAMgASgNEhMKC0RGTE1LQ0lLRk9QGAQgASgJEhMKC0RBRkVKSUVO";
		buffer[4] = "QUJMGAwgASgNEhAKCHN0YWdlX2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[5] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { OCLEJLEFBFOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetReplayTokenCsReq), GetReplayTokenCsReq.Parser, new string[6] { "EBNFHHGKDKE", "ReplayType", "KALAGIBCNAO", "DFLMKCIKFOP", "DAFEJIENABL", "StageId" }, null, null, null, null)
		}));
	}
}
