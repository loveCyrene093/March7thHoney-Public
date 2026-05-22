using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeFightActivityRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeFightActivityRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlRmlnaHRBY3Rpdml0eVJld2FyZENzUmVxLnByb3RvIkUKHFRha2VG" + "aWdodEFjdGl2aXR5UmV3YXJkQ3NSZXESEAoIZ3JvdXBfaWQYByABKA0SEwoL" + "SU5PTUZGQUlFT0EYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeFightActivityRewardCsReq), TakeFightActivityRewardCsReq.Parser, new string[2] { "GroupId", "INOMFFAIEOA" }, null, null, null, null)
		}));
	}
}
