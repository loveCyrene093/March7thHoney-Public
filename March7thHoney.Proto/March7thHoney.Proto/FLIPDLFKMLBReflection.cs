using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FLIPDLFKMLBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FLIPDLFKMLBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTElQRExGS01MQi5wcm90byJJCgtGTElQRExGS01MQhIQCghldmVudF9p" + "ZBgDIAEoDRITCgtFTUZITEJCT0NGSxgFIAEoDRITCgtFQ01OT0ZDTUlHShgH" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FLIPDLFKMLB), FLIPDLFKMLB.Parser, new string[3] { "EventId", "EMFHLBBOCFK", "ECMNOFCMIGJ" }, null, null, null, null)
		}));
	}
}
