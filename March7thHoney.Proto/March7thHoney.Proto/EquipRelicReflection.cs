using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EquipRelicReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EquipRelicReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBFcXVpcFJlbGljLnByb3RvIjMKCkVxdWlwUmVsaWMSDAoEdHlwZRgIIAEo" + "DRIXCg9yZWxpY191bmlxdWVfaWQYCyABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EquipRelic), EquipRelic.Parser, new string[2] { "Type", "RelicUniqueId" }, null, null, null, null)
		}));
	}
}
