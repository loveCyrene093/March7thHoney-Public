using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EquipAetherDividePassiveSkillCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EquipAetherDividePassiveSkillCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihFcXVpcEFldGhlckRpdmlkZVBhc3NpdmVTa2lsbENzUmVxLnByb3RvIlgK" + "IkVxdWlwQWV0aGVyRGl2aWRlUGFzc2l2ZVNraWxsQ3NSZXESDwoHaXRlbV9p" + "ZBgBIAEoDRIMCgRzbG90GAIgASgNEhMKC0lNTUhKTURIREdDGAMgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EquipAetherDividePassiveSkillCsReq), EquipAetherDividePassiveSkillCsReq.Parser, new string[3] { "ItemId", "Slot", "IMMHJMDHDGC" }, null, null, null, null)
		}));
	}
}
