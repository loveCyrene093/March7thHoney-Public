using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCrossInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCrossInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdHZXRDcm9zc0luZm9TY1JzcC5wcm90bxoTRmlnaHRHYW1lTW9kZS5wcm90";
		buffer[1] = "byJvChFHZXRDcm9zc0luZm9TY1JzcBIjCgtQTE9CTUJGUE5GSxgDIAEoDjIO";
		buffer[2] = "LkZpZ2h0R2FtZU1vZGUSDwoHcm9vbV9pZBgEIAEoBBIPCgdyZXRjb2RlGAgg";
		buffer[3] = "ASgNEhMKC0VJRkZETk5CR01DGA4gASgEQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FightGameModeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCrossInfoScRsp), GetCrossInfoScRsp.Parser, new string[4] { "PLOBMBFPNFK", "RoomId", "Retcode", "EIFFDNNBGMC" }, null, null, null, null)
		}));
	}
}
