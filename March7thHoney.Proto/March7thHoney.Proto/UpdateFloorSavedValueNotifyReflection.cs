using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateFloorSavedValueNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateFloorSavedValueNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CiFVcGRhdGVGbG9vclNhdmVkVmFsdWVOb3RpZnkucHJvdG8izQEKG1VwZGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "ZUZsb29yU2F2ZWRWYWx1ZU5vdGlmeRJBCgtzYXZlZF92YWx1ZRgBIAMoCzIs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "LlVwZGF0ZUZsb29yU2F2ZWRWYWx1ZU5vdGlmeS5TYXZlZFZhbHVlRW50cnkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "FAoMZGltZW5zaW9uX2lkGAIgASgNEhAKCHBsYW5lX2lkGAcgASgNEhAKCGZs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "b29yX2lkGAkgASgNGjEKD1NhdmVkVmFsdWVFbnRyeRILCgNrZXkYASABKAkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "DQoFdmFsdWUYAiABKAU6AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateFloorSavedValueNotify), UpdateFloorSavedValueNotify.Parser, new string[4] { "SavedValue", "DimensionId", "PlaneId", "FloorId" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
