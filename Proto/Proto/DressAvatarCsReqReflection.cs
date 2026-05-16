using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DressAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DressAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEcmVzc0F2YXRhckNzUmVxLnByb3RvIkIKEERyZXNzQXZhdGFyQ3NSZXES" + "GwoTZXF1aXBtZW50X3VuaXF1ZV9pZBgCIAEoDRIRCglhdmF0YXJfaWQYCSAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DressAvatarCsReq), DressAvatarCsReq.Parser, new string[2] { "EquipmentUniqueId", "AvatarId" }, null, null, null, null)
		}));
	}
}
