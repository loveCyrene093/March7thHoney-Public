using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesAvatarLevelUpCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesAvatarLevelUpCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFQbGFuZXRGZXNBdmF0YXJMZXZlbFVwQ3NSZXEucHJvdG8iRQobUGxhbmV0" + "RmVzQXZhdGFyTGV2ZWxVcENzUmVxEhMKC09EQURKSUxPRUtPGAMgASgNEhEK" + "CWF2YXRhcl9pZBgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesAvatarLevelUpCsReq), PlanetFesAvatarLevelUpCsReq.Parser, new string[2] { "ODADJILOEKO", "AvatarId" }, null, null, null, null)
		}));
	}
}
