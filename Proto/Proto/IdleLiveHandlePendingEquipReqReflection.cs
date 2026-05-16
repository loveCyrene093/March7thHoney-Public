using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveHandlePendingEquipReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveHandlePendingEquipReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNJZGxlTGl2ZUhhbmRsZVBlbmRpbmdFcXVpcFJlcS5wcm90byIyCh1JZGxl" + "TGl2ZUhhbmRsZVBlbmRpbmdFcXVpcFJlcRIRCglEaXNjYXJkZWQYDCABKAhC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveHandlePendingEquipReq), IdleLiveHandlePendingEquipReq.Parser, new string[1] { "Discarded" }, null, null, null, null)
		}));
	}
}
