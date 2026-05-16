using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PropRogueInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PropRogueInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNQcm9wUm9ndWVJbmZvLnByb3RvIl8KDVByb3BSb2d1ZUluZm8SEwoLQ05Q" + "T0pGSEtFS0gYAiABKA0SEwoLSENNSkRNRk5FTkUYBSABKA0SDwoHcm9vbV9p" + "ZBgIIAEoDRITCgtLR0ZGTkRBSU5BSxgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PropRogueInfo), PropRogueInfo.Parser, new string[4] { "CNPOJFHKEKH", "HCMJDMFNENE", "RoomId", "KGFFNDAINAK" }, null, null, null, null)
		}));
	}
}
