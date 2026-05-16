using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReplaceLineupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReplaceLineupScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSZXBsYWNlTGluZXVwU2NSc3AucHJvdG8iOgoSUmVwbGFjZUxpbmV1cFNj" + "UnNwEg8KB3JldGNvZGUYBCABKA0SEwoLUE9ETERQRUlLS0kYDSABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReplaceLineupScRsp), ReplaceLineupScRsp.Parser, new string[2] { "Retcode", "PODLDPEIKKI" }, null, null, null, null)
		}));
	}
}
