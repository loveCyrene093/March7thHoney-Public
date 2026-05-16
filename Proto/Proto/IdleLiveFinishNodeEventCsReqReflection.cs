using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveFinishNodeEventCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveFinishNodeEventCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJJZGxlTGl2ZUZpbmlzaE5vZGVFdmVudENzUmVxLnByb3RvIh4KHElkbGVM" + "aXZlRmluaXNoTm9kZUV2ZW50Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveFinishNodeEventCsReq), IdleLiveFinishNodeEventCsReq.Parser, null, null, null, null, null)
		}));
	}
}
