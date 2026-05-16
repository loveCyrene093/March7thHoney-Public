using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeRaidNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeRaidNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDaGFsbGVuZ2VSYWlkTm90aWZ5LnByb3RvGhFFTkRPTEVKQ0hLUC5wcm90" + "byI4ChNDaGFsbGVuZ2VSYWlkTm90aWZ5EiEKC09GTENIREVDUERBGA8gASgL" + "MgwuRU5ET0xFSkNIS1BCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { ENDOLEJCHKPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeRaidNotify), ChallengeRaidNotify.Parser, new string[1] { "OFLCHDECPDA" }, null, null, null, null)
		}));
	}
}
