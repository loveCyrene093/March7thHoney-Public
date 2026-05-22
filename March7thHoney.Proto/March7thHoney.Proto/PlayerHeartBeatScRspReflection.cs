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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpQbGF5ZXJIZWFydEJlYXRTY1JzcC5wcm90bxoYQ2xpZW50RG93bmxvYWRE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YXRhLnByb3RvIoMBChRQbGF5ZXJIZWFydEJlYXRTY1JzcBIqCg1kb3dubG9h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZF9kYXRhGAQgASgLMhMuQ2xpZW50RG93bmxvYWREYXRhEg8KB3JldGNvZGUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CCABKA0SFgoOY2xpZW50X3RpbWVfbXMYCSABKAQSFgoOc2VydmVyX3RpbWVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bXMYDiABKARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ClientDownloadDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerHeartBeatScRsp), PlayerHeartBeatScRsp.Parser, new string[4] { "DownloadData", "Retcode", "ClientTimeMs", "ServerTimeMs" }, null, null, null, null)
		}));
	}
}
