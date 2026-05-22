using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueShopMiracleInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueShopMiracleInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZXRSb2d1ZVNob3BNaXJhY2xlSW5mb0NzUmVxLnByb3RvIlYKHEdldFJv" + "Z3VlU2hvcE1pcmFjbGVJbmZvQ3NSZXESIQoZaW50ZXJhY3RlZF9wcm9wX2Vu" + "dGl0eV9pZBgBIAEoDRITCgtOT0tOTk1QTUdHThgDIAEoCEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueShopMiracleInfoCsReq), GetRogueShopMiracleInfoCsReq.Parser, new string[2] { "InteractedPropEntityId", "NOKNNMPMGGN" }, null, null, null, null)
		}));
	}
}
