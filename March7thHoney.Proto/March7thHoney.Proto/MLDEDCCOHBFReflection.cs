using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MLDEDCCOHBFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MLDEDCCOHBFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFNTERFRENDT0hCRi5wcm90byK0AQoLTUxERURDQ09IQkYSMgoLSEFFRUpC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "RkZLR0YYASADKAsyHS5NTERFRENDT0hCRi5IQUVFSkJGRktHRkVudHJ5EhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "C0ZIS0lOQUtHQkJLGAIgASgNEhMKC09GTkRJQ0pKQ0lPGAMgASgNEhMKC1BI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "UEZCTkpPT05QGAQgASgNGjIKEEhBRUVKQkZGS0dGRW50cnkSCwoDa2V5GAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MLDEDCCOHBF), MLDEDCCOHBF.Parser, new string[4] { "HAEEJBFFKGF", "FHKINAKGBBK", "OFNDICJJCIO", "PHPFBNJOONP" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
