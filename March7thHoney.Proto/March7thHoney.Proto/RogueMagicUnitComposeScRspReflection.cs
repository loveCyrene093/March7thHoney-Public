using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicUnitComposeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicUnitComposeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSb2d1ZU1hZ2ljVW5pdENvbXBvc2VTY1JzcC5wcm90byItChpSb2d1ZU1h" + "Z2ljVW5pdENvbXBvc2VTY1JzcBIPCgdyZXRjb2RlGAYgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicUnitComposeScRsp), RogueMagicUnitComposeScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
