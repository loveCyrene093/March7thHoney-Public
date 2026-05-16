using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkUnlockTalentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkUnlockTalentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDbG9ja1BhcmtVbmxvY2tUYWxlbnRTY1JzcC5wcm90byJCChpDbG9ja1Bh" + "cmtVbmxvY2tUYWxlbnRTY1JzcBIPCgdyZXRjb2RlGAEgASgNEhMKC0tGSkVN" + "SU9KTFBKGAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkUnlockTalentScRsp), ClockParkUnlockTalentScRsp.Parser, new string[2] { "Retcode", "KFJEMIOJLPJ" }, null, null, null, null)
		}));
	}
}
