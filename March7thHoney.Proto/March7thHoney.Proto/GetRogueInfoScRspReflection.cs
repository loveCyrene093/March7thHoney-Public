using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRSb2d1ZUluZm9TY1JzcC5wcm90bxoRSlBGR0hDUEdIR08ucHJvdG8i" + "SwoRR2V0Um9ndWVJbmZvU2NSc3ASDwoHcmV0Y29kZRgHIAEoDRIlCg9yb2d1" + "ZV9nYW1lX2luZm8YCyABKAsyDC5KUEZHSENQR0hHT0IWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JPFGHCPGHGOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueInfoScRsp), GetRogueInfoScRsp.Parser, new string[2] { "Retcode", "RogueGameInfo" }, null, null, null, null)
		}));
	}
}
