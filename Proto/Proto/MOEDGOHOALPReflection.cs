using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MOEDGOHOALPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MOEDGOHOALPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNT0VER09IT0FMUC5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJSCgtNT0VE" + "R09IT0FMUBIgCgthdmF0YXJfdHlwZRgDIAEoDjILLkF2YXRhclR5cGUSDgoG" + "ZGFtYWdlGAkgASgBEhEKCWF2YXRhcl9pZBgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MOEDGOHOALP), MOEDGOHOALP.Parser, new string[3] { "AvatarType", "Damage", "AvatarId" }, null, null, null, null)
		}));
	}
}
