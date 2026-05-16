using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerHeartBeatScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerHeartBeatScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpQbGF5ZXJIZWFydEJlYXRTY1JzcC5wcm90bxoYQ2xpZW50RG93bmxvYWRE";
		buffer[1] = "YXRhLnByb3RvIoMBChRQbGF5ZXJIZWFydEJlYXRTY1JzcBIqCg1kb3dubG9h";
		buffer[2] = "ZF9kYXRhGAQgASgLMhMuQ2xpZW50RG93bmxvYWREYXRhEg8KB3JldGNvZGUY";
		buffer[3] = "CCABKA0SFgoOY2xpZW50X3RpbWVfbXMYCSABKAQSFgoOc2VydmVyX3RpbWVf";
		buffer[4] = "bXMYDiABKARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ClientDownloadDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerHeartBeatScRsp), PlayerHeartBeatScRsp.Parser, new string[4] { "DownloadData", "Retcode", "ClientTimeMs", "ServerTimeMs" }, null, null, null, null)
		}));
	}
}
