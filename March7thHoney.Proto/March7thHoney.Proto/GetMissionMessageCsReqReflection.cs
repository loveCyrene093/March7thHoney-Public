using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMissionMessageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMissionMessageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRNaXNzaW9uTWVzc2FnZUNzUmVxLnByb3RvIhgKFkdldE1pc3Npb25N" + "ZXNzYWdlQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionMessageCsReq), GetMissionMessageCsReq.Parser, null, null, null, null, null)
		}));
	}
}
