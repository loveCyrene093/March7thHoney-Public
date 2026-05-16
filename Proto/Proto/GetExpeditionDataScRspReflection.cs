using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetExpeditionDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetExpeditionDataScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChxHZXRFeHBlZGl0aW9uRGF0YVNjUnNwLnByb3RvGhRFeHBlZGl0aW9uSW5m";
		buffer[1] = "by5wcm90byKdAQoWR2V0RXhwZWRpdGlvbkRhdGFTY1JzcBITCgtLQU1CQkZE";
		buffer[2] = "RUJBTRgGIAEoAxIoCg9leHBlZGl0aW9uX2luZm8YByADKAsyDy5FeHBlZGl0";
		buffer[3] = "aW9uSW5mbxIPCgdyZXRjb2RlGAkgASgNEh4KFnRvdGFsX2V4cGVkaXRpb25f";
		buffer[4] = "Y291bnQYDCABKA0SEwoLTkJLRkFFRE9HUEcYDSADKA1CFqoCE01hcmNoN3Ro";
		buffer[5] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ExpeditionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetExpeditionDataScRsp), GetExpeditionDataScRsp.Parser, new string[5] { "KAMBBFDEBAM", "ExpeditionInfo", "Retcode", "TotalExpeditionCount", "NBKFAEDOGPG" }, null, null, null, null)
		}));
	}
}
