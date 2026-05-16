using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JoinLineupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JoinLineupScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVKb2luTGluZXVwU2NSc3AucHJvdG8iIgoPSm9pbkxpbmV1cFNjUnNwEg8K" + "B3JldGNvZGUYBiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JoinLineupScRsp), JoinLineupScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
