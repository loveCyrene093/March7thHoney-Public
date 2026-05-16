using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IGDMBAILEHIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IGDMBAILEHIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJR0RNQkFJTEVISS5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJYCgtJR0RN" + "QkFJTEVISRINCgVsZXZlbBgHIAEoDRIKCgJpZBgLIAEoDRIMCgRzbG90GA0g" + "ASgNEiAKC2F2YXRhcl90eXBlGA8gASgOMgsuQXZhdGFyVHlwZUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IGDMBAILEHI), IGDMBAILEHI.Parser, new string[4] { "Level", "Id", "Slot", "AvatarType" }, null, null, null, null)
		}));
	}
}
