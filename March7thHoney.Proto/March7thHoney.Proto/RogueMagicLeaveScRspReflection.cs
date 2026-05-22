using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicLeaveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicLeaveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZU1hZ2ljTGVhdmVTY1JzcC5wcm90bxoRSktBSURLSUdFR1AucHJv" + "dG8iSgoUUm9ndWVNYWdpY0xlYXZlU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIh" + "CgtBRkxKSkpGQ0JJThgOIAEoCzIMLkpLQUlES0lHRUdQQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { JKAIDKIGEGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicLeaveScRsp), RogueMagicLeaveScRsp.Parser, new string[2] { "Retcode", "AFLJJJFCBIN" }, null, null, null, null)
		}));
	}
}
