using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueShopBeginBattleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueShopBeginBattleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Sb2d1ZVNob3BCZWdpbkJhdHRsZUNzUmVxLnByb3RvIj4KGVJvZ3VlU2hv" + "cEJlZ2luQmF0dGxlQ3NSZXESIQoZaW50ZXJhY3RlZF9wcm9wX2VudGl0eV9p" + "ZBgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueShopBeginBattleCsReq), RogueShopBeginBattleCsReq.Parser, new string[1] { "InteractedPropEntityId" }, null, null, null, null)
		}));
	}
}
