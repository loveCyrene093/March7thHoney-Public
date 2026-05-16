using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateRogueAdventureRoomScoreCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateRogueAdventureRoomScoreCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihVcGRhdGVSb2d1ZUFkdmVudHVyZVJvb21TY29yZUNzUmVxLnByb3RvIksK" + "IlVwZGF0ZVJvZ3VlQWR2ZW50dXJlUm9vbVNjb3JlQ3NSZXESEAoIc2NvcmVf" + "aWQYBiABKA0SEwoLTklJRUtDTUJFTkkYCCABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateRogueAdventureRoomScoreCsReq), UpdateRogueAdventureRoomScoreCsReq.Parser, new string[2] { "ScoreId", "NIIEKCMBENI" }, null, null, null, null)
		}));
	}
}
