using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelEndGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelEndGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGltZXJhRHVlbEVuZEdhbWVTY1JzcC5wcm90bxoRSE9CQ0lPS0tOS0gu" + "cHJvdG8iTQoXQ2hpbWVyYUR1ZWxFbmRHYW1lU2NSc3ASDwoHcmV0Y29kZRgD" + "IAEoDRIhCgtDS0lNT0VMUE9BQhgIIAEoCzIMLkhPQkNJT0tLTktIQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { HOBCIOKKNKHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelEndGameScRsp), ChimeraDuelEndGameScRsp.Parser, new string[2] { "Retcode", "CKIMOELPOAB" }, null, null, null, null)
		}));
	}
}
