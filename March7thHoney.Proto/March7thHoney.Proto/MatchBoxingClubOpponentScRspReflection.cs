using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchBoxingClubOpponentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchBoxingClubOpponentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJNYXRjaEJveGluZ0NsdWJPcHBvbmVudFNjUnNwLnByb3RvGhFPT01JTkdF" + "RlBBRi5wcm90byJSChxNYXRjaEJveGluZ0NsdWJPcHBvbmVudFNjUnNwEg8K" + "B3JldGNvZGUYBCABKA0SIQoLT1BDR05KTUdKREUYBiABKAsyDC5PT01JTkdF" + "RlBBRkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OOMINGEFPAFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchBoxingClubOpponentScRsp), MatchBoxingClubOpponentScRsp.Parser, new string[2] { "Retcode", "OPCGNJMGJDE" }, null, null, null, null)
		}));
	}
}
