using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesApplyCardPieceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesApplyCardPieceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJQbGFuZXRGZXNBcHBseUNhcmRQaWVjZUNzUmVxLnByb3RvIkgKHFBsYW5l" + "dEZlc0FwcGx5Q2FyZFBpZWNlQ3NSZXESEwoLREpERUJLUEdKRE4YAyADKA0S" + "EwoLdGVsZXBvcnRfaWQYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesApplyCardPieceCsReq), PlanetFesApplyCardPieceCsReq.Parser, new string[2] { "DJDEBKPGJDN", "TeleportId" }, null, null, null, null)
		}));
	}
}
