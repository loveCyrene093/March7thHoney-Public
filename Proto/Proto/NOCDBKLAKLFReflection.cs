using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOCDBKLAKLFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOCDBKLAKLFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFOT0NEQktMQUtMRi5wcm90bxoQTGluZXVwSW5mby5wcm90bxoRTUFERUVO";
		buffer[1] = "QUJPS0UucHJvdG8aD1NjZW5lSW5mby5wcm90byJoCgtOT0NEQktMQUtMRhIZ";
		buffer[2] = "CgVzY2VuZRgHIAEoCzIKLlNjZW5lSW5mbxIhCgtFTlBBSUNOTENNSxgIIAEo";
		buffer[3] = "CzIMLk1BREVFTkFCT0tFEhsKBmxpbmV1cBgPIAEoCzILLkxpbmV1cEluZm9C";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			LineupInfoReflection.Descriptor,
			MADEENABOKEReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NOCDBKLAKLF), NOCDBKLAKLF.Parser, new string[3] { "Scene", "ENPAICNLCMK", "Lineup" }, null, null, null, null)
		}));
	}
}
