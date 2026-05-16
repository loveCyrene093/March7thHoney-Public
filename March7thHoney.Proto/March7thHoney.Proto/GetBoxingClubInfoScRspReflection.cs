using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBoxingClubInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBoxingClubInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRCb3hpbmdDbHViSW5mb1NjUnNwLnByb3RvGhFPT01JTkdFRlBBRi5w" + "cm90byJPChZHZXRCb3hpbmdDbHViSW5mb1NjUnNwEg8KB3JldGNvZGUYAyAB" + "KA0SJAoOY2hhbGxlbmdlX2xpc3QYDSADKAsyDC5PT01JTkdFRlBBRkIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OOMINGEFPAFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBoxingClubInfoScRsp), GetBoxingClubInfoScRsp.Parser, new string[2] { "Retcode", "ChallengeList" }, null, null, null, null)
		}));
	}
}
