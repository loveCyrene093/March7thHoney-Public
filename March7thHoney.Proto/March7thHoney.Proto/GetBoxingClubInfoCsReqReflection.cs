using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBoxingClubInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBoxingClubInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRCb3hpbmdDbHViSW5mb0NzUmVxLnByb3RvIhgKFkdldEJveGluZ0Ns" + "dWJJbmZvQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBoxingClubInfoCsReq), GetBoxingClubInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
