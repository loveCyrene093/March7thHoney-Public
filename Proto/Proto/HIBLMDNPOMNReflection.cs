using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HIBLMDNPOMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HIBLMDNPOMNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISUJMTUROUE9NTi5wcm90byIiCgtISUJMTUROUE9NThITCgtBRlBLSkxC" + "TFBMRxgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HIBLMDNPOMN), HIBLMDNPOMN.Parser, new string[1] { "AFPKJLBLPLG" }, null, null, null, null)
		}));
	}
}
