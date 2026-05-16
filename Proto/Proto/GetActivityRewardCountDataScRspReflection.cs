using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetActivityRewardCountDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetActivityRewardCountDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiVHZXRBY3Rpdml0eVJld2FyZENvdW50RGF0YVNjUnNwLnByb3RvGhFHRkFE";
		buffer[1] = "QkNNR0ZGRi5wcm90byJeCh9HZXRBY3Rpdml0eVJld2FyZENvdW50RGF0YVNj";
		buffer[2] = "UnNwEioKFGNvbnRlbnRfcGFja2FnZV9saXN0GAQgAygLMgwuR0ZBREJDTUdG";
		buffer[3] = "RkYSDwoHcmV0Y29kZRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GFADBCMGFFFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetActivityRewardCountDataScRsp), GetActivityRewardCountDataScRsp.Parser, new string[2] { "ContentPackageList", "Retcode" }, null, null, null, null)
		}));
	}
}
