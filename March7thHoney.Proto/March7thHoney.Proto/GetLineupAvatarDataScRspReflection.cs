using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLineupAvatarDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLineupAvatarDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRMaW5ldXBBdmF0YXJEYXRhU2NSc3AucHJvdG8aFkxpbmV1cEF2YXRh" + "ckRhdGEucHJvdG8iWAoYR2V0TGluZXVwQXZhdGFyRGF0YVNjUnNwEisKEGF2" + "YXRhcl9kYXRhX2xpc3QYAyADKAsyES5MaW5ldXBBdmF0YXJEYXRhEg8KB3Jl" + "dGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { LineupAvatarDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLineupAvatarDataScRsp), GetLineupAvatarDataScRsp.Parser, new string[2] { "AvatarDataList", "Retcode" }, null, null, null, null)
		}));
	}
}
