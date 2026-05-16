using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGMMDCCGLJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGMMDCCGLJDReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFQR01NRENDR0xKRC5wcm90bxoRSEhNRE9ORU9FQUsucHJvdG8iqgEKC1BH";
		buffer[1] = "TU1EQ0NHTEpEEjIKC0dLQU9OREJCREhGGAIgAygLMh0uUEdNTURDQ0dMSkQu";
		buffer[2] = "R0tBT05EQkJESEZFbnRyeRIQCghwYW5lbF9pZBgGIAEoDRITCgtPR0hGTU9B";
		buffer[3] = "TFBFTxgKIAEoDRpAChBHS0FPTkRCQkRIRkVudHJ5EgsKA2tleRgBIAEoDRIb";
		buffer[4] = "CgV2YWx1ZRgCIAEoCzIMLkhITURPTkVPRUFLOgI4AUIWqgITTWFyY2g3dGhI";
		buffer[5] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HHMDONEOEAKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGMMDCCGLJD), PGMMDCCGLJD.Parser, new string[3] { "GKAONDBBDHF", "PanelId", "OGHFMOALPEO" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
