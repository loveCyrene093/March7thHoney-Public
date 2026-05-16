using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChallengePeakDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChallengePeakDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9HZXRDaGFsbGVuZ2VQZWFrRGF0YVNjUnNwLnByb3RvGhhDaGFsbGVuZ2VQ";
		buffer[1] = "ZWFrR3JvdXAucHJvdG8ifwoZR2V0Q2hhbGxlbmdlUGVha0RhdGFTY1JzcBId";
		buffer[2] = "ChVjdXJyZW50X3BlYWtfZ3JvdXBfaWQYBCABKA0SMgoVY2hhbGxlbmdlX3Bl";
		buffer[3] = "YWtfZ3JvdXBzGAsgAygLMhMuQ2hhbGxlbmdlUGVha0dyb3VwEg8KB3JldGNv";
		buffer[4] = "ZGUYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ChallengePeakGroupReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengePeakDataScRsp), GetChallengePeakDataScRsp.Parser, new string[3] { "CurrentPeakGroupId", "ChallengePeakGroups", "Retcode" }, null, null, null, null)
		}));
	}
}
