using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightGiveUpCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightGiveUpCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZGaWdodEdpdmVVcENzUmVxLnByb3RvIicKEEZpZ2h0R2l2ZVVwQ3NSZXES" + "EwoLRUlGRkROTkJHTUMYDyABKARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightGiveUpCsReq), FightGiveUpCsReq.Parser, new string[1] { "EIFFDNNBGMC" }, null, null, null, null)
		}));
	}
}
