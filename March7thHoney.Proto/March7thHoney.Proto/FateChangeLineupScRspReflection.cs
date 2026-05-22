using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateChangeLineupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateChangeLineupScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtGYXRlQ2hhbmdlTGluZXVwU2NSc3AucHJvdG8iKAoVRmF0ZUNoYW5nZUxp" + "bmV1cFNjUnNwEg8KB3JldGNvZGUYCiABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateChangeLineupScRsp), FateChangeLineupScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
