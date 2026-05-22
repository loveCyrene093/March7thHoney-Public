using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookFinishInteractionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookFinishInteractionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVUYXJvdEJvb2tGaW5pc2hJbnRlcmFjdGlvbkNzUmVxLnByb3RvIjYKH1Rh" + "cm90Qm9va0ZpbmlzaEludGVyYWN0aW9uQ3NSZXESEwoLTkdFSUpCTUNQTkEY" + "DyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookFinishInteractionCsReq), TarotBookFinishInteractionCsReq.Parser, new string[1] { "NGEIJBMCPNA" }, null, null, null, null)
		}));
	}
}
