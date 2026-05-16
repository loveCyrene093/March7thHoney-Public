using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFightActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFightActivityDataScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "Ch9HZXRGaWdodEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhFJRk5FQ0pPT0lH";
		buffer[1] = "Ry5wcm90byLvAQoZR2V0RmlnaHRBY3Rpdml0eURhdGFTY1JzcBJACgtJTUdH";
		buffer[2] = "UE1FT0pBShgBIAMoCzIrLkdldEZpZ2h0QWN0aXZpdHlEYXRhU2NSc3AuSU1H";
		buffer[3] = "R1BNRU9KQUpFbnRyeRITCgtJQkNNTERQSkdDSxgCIAEoCBIPCgdyZXRjb2Rl";
		buffer[4] = "GAUgASgNEiEKC0VDR0xHREtERElEGAogAygLMgwuSUZORUNKT09JR0cSEwoL";
		buffer[5] = "d29ybGRfbGV2ZWwYDiABKA0aMgoQSU1HR1BNRU9KQUpFbnRyeRILCgNrZXkY";
		buffer[6] = "ASABKA0SDQoFdmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[7] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { IFNECJOOIGGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFightActivityDataScRsp), GetFightActivityDataScRsp.Parser, new string[5] { "IMGGPMEOJAJ", "IBCMLDPJGCK", "Retcode", "ECGLGDKDDID", "WorldLevel" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
