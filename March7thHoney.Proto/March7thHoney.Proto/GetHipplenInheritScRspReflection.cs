using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetHipplenInheritScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetHipplenInheritScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRIaXBwbGVuSW5oZXJpdFNjUnNwLnByb3RvIkgKFkdldEhpcHBsZW5J" + "bmhlcml0U2NSc3ASHQoVZ3JpZF9maWdodF90cmFpdF9pbmZvGAwgAygNEg8K" + "B3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetHipplenInheritScRsp), GetHipplenInheritScRsp.Parser, new string[2] { "GridFightTraitInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
