using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPlayerDetailInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPlayerDetailInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRQbGF5ZXJEZXRhaWxJbmZvU2NSc3AucHJvdG8aFlBsYXllckRldGFp" + "bEluZm8ucHJvdG8iUwoYR2V0UGxheWVyRGV0YWlsSW5mb1NjUnNwEg8KB3Jl" + "dGNvZGUYBSABKA0SJgoLZGV0YWlsX2luZm8YCSABKAsyES5QbGF5ZXJEZXRh" + "aWxJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PlayerDetailInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerDetailInfoScRsp), GetPlayerDetailInfoScRsp.Parser, new string[2] { "Retcode", "DetailInfo" }, null, null, null, null)
		}));
	}
}
