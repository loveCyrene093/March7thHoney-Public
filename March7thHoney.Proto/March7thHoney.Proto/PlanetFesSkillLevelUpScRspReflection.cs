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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBQbGFuZXRGZXNTa2lsbExldmVsVXBTY1JzcC5wcm90bxoRRkJCTURGRE9F";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RUYucHJvdG8idQoaUGxhbmV0RmVzU2tpbGxMZXZlbFVwU2NSc3ASEAoIc2tp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bGxfaWQYAiABKA0SDwoHcmV0Y29kZRgDIAEoDRITCgtza2lsbF9sZXZlbBgF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAEoDRIfCglpdGVtX2Nvc3QYCSABKAsyDC5GQkJNREZET0VFRkIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { FBBMDFDOEEFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesSkillLevelUpScRsp), PlanetFesSkillLevelUpScRsp.Parser, new string[4] { "SkillId", "Retcode", "SkillLevel", "ItemCost" }, null, null, null, null)
		}));
	}
}
