using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuitRogueScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuitRogueScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRRdWl0Um9ndWVTY1JzcC5wcm90bxoRSlBGR0hDUEdIR08ucHJvdG8iSAoO" + "UXVpdFJvZ3VlU2NSc3ASJQoPcm9ndWVfZ2FtZV9pbmZvGAUgASgLMgwuSlBG" + "R0hDUEdIR08SDwoHcmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[1] { JPFGHCPGHGOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuitRogueScRsp), QuitRogueScRsp.Parser, new string[2] { "RogueGameInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
