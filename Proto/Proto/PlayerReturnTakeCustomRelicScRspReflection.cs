using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnTakeCustomRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnTakeCustomRelicScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiZQbGF5ZXJSZXR1cm5UYWtlQ3VzdG9tUmVsaWNTY1JzcC5wcm90bxoLUmVs";
		buffer[1] = "aWMucHJvdG8iYgogUGxheWVyUmV0dXJuVGFrZUN1c3RvbVJlbGljU2NSc3AS";
		buffer[2] = "GgoKcmVsaWNfbGlzdBgCIAMoCzIGLlJlbGljEhEKCWF2YXRhcl9pZBgHIAEo";
		buffer[3] = "DRIPCgdyZXRjb2RlGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RelicReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnTakeCustomRelicScRsp), PlayerReturnTakeCustomRelicScRsp.Parser, new string[3] { "RelicList", "AvatarId", "Retcode" }, null, null, null, null)
		}));
	}
}
