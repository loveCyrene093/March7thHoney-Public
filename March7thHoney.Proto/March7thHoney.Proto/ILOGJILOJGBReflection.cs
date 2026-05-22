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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFJTE9HSklMT0pHQi5wcm90byKKAQoLSUxPR0pJTE9KR0ISEwoLREtNRkFM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QUlMUEMYASADKA0SMgoLQk9IQkJOSUJGS0wYAiADKAsyHS5JTE9HSklMT0pH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Qi5CT0hCQk5JQkZLTEVudHJ5GjIKEEJPSEJCTklCRktMRW50cnkSCwoDa2V5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ILOGJILOJGB), ILOGJILOJGB.Parser, new string[2] { "DKMFALAILPC", "BOHBBNIBFKL" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
