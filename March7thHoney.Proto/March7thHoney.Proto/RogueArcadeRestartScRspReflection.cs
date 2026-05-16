using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueArcadeRestartScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueArcadeRestartScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Sb2d1ZUFyY2FkZVJlc3RhcnRTY1JzcC5wcm90bxoRS0VFREpCSUVKT0Yu" + "cHJvdG8iTQoXUm9ndWVBcmNhZGVSZXN0YXJ0U2NSc3ASDwoHcmV0Y29kZRgD" + "IAEoDRIhCgtBRkxKSkpGQ0JJThgGIAEoCzIMLktFRURKQklFSk9GQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { KEEDJBIEJOFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeRestartScRsp), RogueArcadeRestartScRsp.Parser, new string[2] { "Retcode", "AFLJJJFCBIN" }, null, null, null, null)
		}));
	}
}
