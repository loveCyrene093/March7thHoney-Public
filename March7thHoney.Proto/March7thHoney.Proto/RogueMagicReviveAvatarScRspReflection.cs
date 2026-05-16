using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicReviveAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicReviveAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSb2d1ZU1hZ2ljUmV2aXZlQXZhdGFyU2NSc3AucHJvdG8aEkl0ZW1Db3N0" + "RGF0YS5wcm90byJSChtSb2d1ZU1hZ2ljUmV2aXZlQXZhdGFyU2NSc3ASDwoH" + "cmV0Y29kZRgDIAEoDRIiCgtFQk1LQkRKTUFBRhgGIAEoCzINLkl0ZW1Db3N0" + "RGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicReviveAvatarScRsp), RogueMagicReviveAvatarScRsp.Parser, new string[2] { "Retcode", "EBMKBDJMAAF" }, null, null, null, null)
		}));
	}
}
