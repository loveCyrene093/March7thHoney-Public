using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendListInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendListInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRGcmllbmRMaXN0SW5mb0NzUmVxLnByb3RvIhgKFkdldEZyaWVuZExp" + "c3RJbmZvQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendListInfoCsReq), GetFriendListInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
