using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesDeliverPamCargoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesDeliverPamCargoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNQbGFuZXRGZXNEZWxpdmVyUGFtQ2FyZ29Dc1JlcS5wcm90byJHCh1QbGFu" + "ZXRGZXNEZWxpdmVyUGFtQ2FyZ29Dc1JlcRIRCglhdmF0YXJfaWQYAiABKA0S" + "EwoLQUZBSERCUEdKTEwYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesDeliverPamCargoCsReq), PlanetFesDeliverPamCargoCsReq.Parser, new string[2] { "AvatarId", "AFAHDBPGJLL" }, null, null, null, null)
		}));
	}
}
