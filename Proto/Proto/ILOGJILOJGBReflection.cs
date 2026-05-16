using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ILOGJILOJGBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ILOGJILOJGBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFJTE9HSklMT0pHQi5wcm90byKKAQoLSUxPR0pJTE9KR0ISEwoLREtNRkFM";
		buffer[1] = "QUlMUEMYASADKA0SMgoLQk9IQkJOSUJGS0wYAiADKAsyHS5JTE9HSklMT0pH";
		buffer[2] = "Qi5CT0hCQk5JQkZLTEVudHJ5GjIKEEJPSEJCTklCRktMRW50cnkSCwoDa2V5";
		buffer[3] = "GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ILOGJILOJGB), ILOGJILOJGB.Parser, new string[2] { "DKMFALAILPC", "BOHBBNIBFKL" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
