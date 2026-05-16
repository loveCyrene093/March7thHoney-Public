using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyGamePlayStartCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyGamePlayStartCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUcmFpblBhcnR5R2FtZVBsYXlTdGFydENzUmVxLnByb3RvIkgKHFRyYWlu" + "UGFydHlHYW1lUGxheVN0YXJ0Q3NSZXESEwoLRE1NTkNOR0dQSEwYBSADKA0S" + "EwoLTUFPTkxIQktPRksYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyGamePlayStartCsReq), TrainPartyGamePlayStartCsReq.Parser, new string[2] { "DMMNCNGGPHL", "MAONLHBKOFK" }, null, null, null, null)
		}));
	}
}
