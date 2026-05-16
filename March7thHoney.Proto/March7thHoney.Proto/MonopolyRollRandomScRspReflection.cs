using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyRollRandomScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyRollRandomScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Nb25vcG9seVJvbGxSYW5kb21TY1JzcC5wcm90bxoRQkxJSkVLS09JSkgu" + "cHJvdG8iXwoXTW9ub3BvbHlSb2xsUmFuZG9tU2NSc3ASEAoIZXZlbnRfaWQY" + "AiABKA0SDwoHcmV0Y29kZRgKIAEoDRIhCgtHR0xET0dJSEZMRxgPIAEoCzIM" + "LkJMSUpFS0tPSUpIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { BLIJEKKOIJHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyRollRandomScRsp), MonopolyRollRandomScRsp.Parser, new string[3] { "EventId", "Retcode", "GGLDOGIHFLG" }, null, null, null, null)
		}));
	}
}
