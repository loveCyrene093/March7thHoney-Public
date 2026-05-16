using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KBAHGNNEMGGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KBAHGNNEMGGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQkFIR05ORU1HRy5wcm90byIiCgtLQkFIR05ORU1HRxITCgtwbGF5ZXJf" + "ZGF0YRgBIAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KBAHGNNEMGG), KBAHGNNEMGG.Parser, new string[1] { "PlayerData" }, null, null, null, null)
		}));
	}
}
