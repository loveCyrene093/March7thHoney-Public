using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayBackGroundMusicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayBackGroundMusicScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5QbGF5QmFja0dyb3VuZE11c2ljU2NSc3AucHJvdG8aEU1DUFBJRUpFQkVG" + "LnByb3RvIk4KGFBsYXlCYWNrR3JvdW5kTXVzaWNTY1JzcBIhCgtKSUxLT1BJ" + "TkxEQxgIIAEoCzIMLk1DUFBJRUpFQkVGEg8KB3JldGNvZGUYDCABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MCPPIEJEBEFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayBackGroundMusicScRsp), PlayBackGroundMusicScRsp.Parser, new string[2] { "JILKOPINLDC", "Retcode" }, null, null, null, null)
		}));
	}
}
