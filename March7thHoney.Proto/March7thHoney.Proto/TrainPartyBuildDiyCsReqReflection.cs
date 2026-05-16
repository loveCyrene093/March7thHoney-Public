using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyBuildDiyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyBuildDiyCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UcmFpblBhcnR5QnVpbGREaXlDc1JlcS5wcm90byJtChdUcmFpblBhcnR5" + "QnVpbGREaXlDc1JlcRIUCgxkaWNlX3Nsb3RfaWQYAiABKA0SDwoHYXJlYV9p" + "ZBgKIAEoDRIWCg5kaXlfZHluYW1pY19pZBgLIAEoDRITCgtBRkdOTERJTUJH" + "QhgMIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyBuildDiyCsReq), TrainPartyBuildDiyCsReq.Parser, new string[4] { "DiceSlotId", "AreaId", "DiyDynamicId", "AFGNLDIMBGB" }, null, null, null, null)
		}));
	}
}
