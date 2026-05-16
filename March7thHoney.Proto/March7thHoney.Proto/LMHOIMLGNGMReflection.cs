using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMHOIMLGNGMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMHOIMLGNGMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFMTUhPSU1MR05HTS5wcm90bxoeRGlmZmljdWx0eUFkanVzdG1lbnRUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "LnByb3RvGhFOSEpMSkJKSktGSi5wcm90byJsCgtMTUhPSU1MR05HTRIhCgtB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "TEZITkVIT0JKQRgFIAEoDjIMLk5ISkxKQkpKS0ZKEgoKAmlkGAggASgNEi4K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "C01KTEhMTE1KSEdKGA8gASgOMhkuRGlmZmljdWx0eUFkanVzdG1lbnRUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			DifficultyAdjustmentTypeReflection.Descriptor,
			NHJLJBJJKFJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMHOIMLGNGM), LMHOIMLGNGM.Parser, new string[3] { "ALFHNEHOBJA", "Id", "MJLHLLMJHGJ" }, null, null, null, null)
		}));
	}
}
