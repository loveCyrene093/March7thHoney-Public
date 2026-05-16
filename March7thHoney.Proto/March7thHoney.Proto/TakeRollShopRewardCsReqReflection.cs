using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRollShopRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRollShopRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UYWtlUm9sbFNob3BSZXdhcmRDc1JlcS5wcm90byIvChdUYWtlUm9sbFNo" + "b3BSZXdhcmRDc1JlcRIUCgxyb2xsX3Nob3BfaWQYCyABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRollShopRewardCsReq), TakeRollShopRewardCsReq.Parser, new string[1] { "RollShopId" }, null, null, null, null)
		}));
	}
}
