using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesSkillLevelUpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesSkillLevelUpScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBQbGFuZXRGZXNTa2lsbExldmVsVXBTY1JzcC5wcm90bxoRRkJCTURGRE9F";
		buffer[1] = "RUYucHJvdG8idQoaUGxhbmV0RmVzU2tpbGxMZXZlbFVwU2NSc3ASEAoIc2tp";
		buffer[2] = "bGxfaWQYAiABKA0SDwoHcmV0Y29kZRgDIAEoDRITCgtza2lsbF9sZXZlbBgF";
		buffer[3] = "IAEoDRIfCglpdGVtX2Nvc3QYCSABKAsyDC5GQkJNREZET0VFRkIWqgITTWFy";
		buffer[4] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FBBMDFDOEEFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesSkillLevelUpScRsp), PlanetFesSkillLevelUpScRsp.Parser, new string[4] { "SkillId", "Retcode", "SkillLevel", "ItemCost" }, null, null, null, null)
		}));
	}
}
