using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MazeGroupReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MazeGroupReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Cg9NYXplR3JvdXAucHJvdG8i2gEKCU1hemVHcm91cBIQCghncm91cF9pZBgE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "IAEoDRIXCg9pc19uZWVkX3JlZnJlc2gYBiABKAgSJgoeZGVzdG9yeV9tb25z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dGVyX2NvbmZpZ19pZF9saXN0GAsgAygNEjEKDHByb3BlcnR5X21hcBgMIAMo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "CzIbLk1hemVHcm91cC5Qcm9wZXJ0eU1hcEVudHJ5EhMKC21vZGlmeV90aW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "GA8gASgDGjIKEFByb3BlcnR5TWFwRW50cnkSCwoDa2V5GAEgASgJEg0KBXZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "bHVlGAIgASgFOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MazeGroup), MazeGroup.Parser, new string[5] { "GroupId", "IsNeedRefresh", "DestoryMonsterConfigIdList", "PropertyMap", "ModifyTime" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
