using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendDevelopmentInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendDevelopmentInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHZXRGcmllbmREZXZlbG9wbWVudEluZm9Dc1JlcS5wcm90byIsCh1HZXRG" + "cmllbmREZXZlbG9wbWVudEluZm9Dc1JlcRILCgN1aWQYCSABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendDevelopmentInfoCsReq), GetFriendDevelopmentInfoCsReq.Parser, new string[1] { "Uid" }, null, null, null, null)
		}));
	}
}
