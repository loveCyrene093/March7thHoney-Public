using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournReviveAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournReviveAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSb2d1ZVRvdXJuUmV2aXZlQXZhdGFyU2NSc3AucHJvdG8aEkl0ZW1Db3N0" + "RGF0YS5wcm90byJSChtSb2d1ZVRvdXJuUmV2aXZlQXZhdGFyU2NSc3ASDwoH" + "cmV0Y29kZRgBIAEoDRIiCgtFQk1LQkRKTUFBRhgFIAEoCzINLkl0ZW1Db3N0" + "RGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournReviveAvatarScRsp), RogueTournReviveAvatarScRsp.Parser, new string[2] { "Retcode", "EBMKBDJMAAF" }, null, null, null, null)
		}));
	}
}
