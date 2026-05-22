using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetHeadIconCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetHeadIconCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZTZXRIZWFkSWNvbkNzUmVxLnByb3RvIh4KEFNldEhlYWRJY29uQ3NSZXES" + "CgoCaWQYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetHeadIconCsReq), SetHeadIconCsReq.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
