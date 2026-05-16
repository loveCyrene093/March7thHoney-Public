using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookModifyEnergyScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookModifyEnergyScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNUYXJvdEJvb2tNb2RpZnlFbmVyZ3lTY05vdGlmeS5wcm90byJMCh1UYXJv" + "dEJvb2tNb2RpZnlFbmVyZ3lTY05vdGlmeRIWCg5zdWJfbWlzc2lvbl9pZBgH" + "IAEoDRITCgtlbmVyZ3lfaW5mbxgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookModifyEnergyScNotify), TarotBookModifyEnergyScNotify.Parser, new string[2] { "SubMissionId", "EnergyInfo" }, null, null, null, null)
		}));
	}
}
