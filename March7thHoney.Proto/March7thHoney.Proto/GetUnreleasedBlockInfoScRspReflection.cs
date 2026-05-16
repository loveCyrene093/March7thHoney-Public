using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetUnreleasedBlockInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetUnreleasedBlockInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRVbnJlbGVhc2VkQmxvY2tJbmZvU2NSc3AucHJvdG8ibQobR2V0VW5y" + "ZWxlYXNlZEJsb2NrSW5mb1NjUnNwEhMKC0REQkZFRUlHUEpJGAMgASgDEhMK" + "C0dPTU5HQUFESkxNGAUgAygNEhMKC0ZMRlBPSkZMSE9EGAggAygNEg8KB3Jl" + "dGNvZGUYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetUnreleasedBlockInfoScRsp), GetUnreleasedBlockInfoScRsp.Parser, new string[4] { "DDBFEEIGPJI", "GOMNGAADJLM", "FLFPOJFLHOD", "Retcode" }, null, null, null, null)
		}));
	}
}
