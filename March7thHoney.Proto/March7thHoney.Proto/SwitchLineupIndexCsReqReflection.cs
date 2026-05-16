using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchLineupIndexCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchLineupIndexCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTd2l0Y2hMaW5ldXBJbmRleENzUmVxLnByb3RvIicKFlN3aXRjaExpbmV1" + "cEluZGV4Q3NSZXESDQoFaW5kZXgYBiABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchLineupIndexCsReq), SwitchLineupIndexCsReq.Parser, new string[1] { "Index" }, null, null, null, null)
		}));
	}
}
