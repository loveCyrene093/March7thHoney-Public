using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuyNpcStuffCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuyNpcStuffCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZCdXlOcGNTdHVmZkNzUmVxLnByb3RvIicKEEJ1eU5wY1N0dWZmQ3NSZXES" + "EwoLR0tGRUdJQkdFR0kYBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuyNpcStuffCsReq), BuyNpcStuffCsReq.Parser, new string[1] { "GKFEGIBGEGI" }, null, null, null, null)
		}));
	}
}
