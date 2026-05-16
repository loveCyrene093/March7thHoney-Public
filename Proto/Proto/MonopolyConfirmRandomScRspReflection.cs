using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyConfirmRandomScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyConfirmRandomScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBNb25vcG9seUNvbmZpcm1SYW5kb21TY1JzcC5wcm90bxoRQkxJSkVLS09J";
		buffer[1] = "SkgucHJvdG8iYgoaTW9ub3BvbHlDb25maXJtUmFuZG9tU2NSc3ASEAoIZXZl";
		buffer[2] = "bnRfaWQYBiABKA0SDwoHcmV0Y29kZRgIIAEoDRIhCgtHR0xET0dJSEZMRxgN";
		buffer[3] = "IAEoCzIMLkJMSUpFS0tPSUpIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BLIJEKKOIJHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyConfirmRandomScRsp), MonopolyConfirmRandomScRsp.Parser, new string[3] { "EventId", "Retcode", "GGLDOGIHFLG" }, null, null, null, null)
		}));
	}
}
